﻿using KafeKod.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeKod
{
    public partial class Form1 : Form
    {
        Kafeveri db;
        


        public Form1()
        {
            VerileriOku();
           // db = new Kafeveri();

            //OrnekVerileriYukle();
            InitializeComponent();
            MasalariOlustur();

        }

        private void VerileriOku()
        {
            try
            {
                string json = File.ReadAllText("veri.json");
                db = JsonConvert.DeserializeObject<Kafeveri>(json);
            }
            catch (Exception)
            {

                db = new Kafeveri();
            }
        }

        //private void OrnekVerileriYukle()
        //{
        //    db.Urunler = new List<Urun>
        //    {
        //        new Urun {UrunAd = "Kola", BirimFiyat =6.99m },

        //        new Urun {UrunAd = "Çay", BirimFiyat =3.99m },

        //    };
        //    db.Urunler.Sort();

        //}

        private void MasalariOlustur()
        {
            #region ListView Imajlarının Hazırlanması
            ImageList il = new ImageList();
            il.Images.Add("bos", Properties.Resources.masabos);
            il.Images.Add("dolu", Properties.Resources.masadolu);
            il.ImageSize = new Size(64, 64);
            lvwMasalar.LargeImageList = il;

            #endregion

            ListViewItem lvi;
            for (int i = 1; i <= db.MasaAdet; i++)
            {
                lvi = new ListViewItem("Masa" + i);
                //masa no değeriyle kayıtlı bir sipariş var mı?
                Siparis sip = db.AktifSiparisler.FirstOrDefault(x => x.MasaNo == i);


                //Siparis sip = null;
                //foreach (Siparis x in db.AktifSiparisler)
                //{
                //    if (x.MasaNo == i)
                //    {
                //        sip = x;
                //        break;
                //    }
                //}

                if (sip==null)
                {
                    lvi.Tag = i;
                    lvi.ImageKey = "bos";
                }
                else
                {
                lvi.Tag = sip;
                lvi.ImageKey = "dolu";

                }
                lvwMasalar.Items.Add(lvi);

            }
        }

        private void lvwMasalar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var lvi = lvwMasalar.SelectedItems[0];
                lvi.ImageKey = "dolu";

                Siparis sip;
                //masa doluysa olanı al, boşsa yeni sipariş oluştur
                if (lvi.Tag is Siparis)
                {
                    sip = (Siparis)lvi.Tag;

                }
                else
                {
                    sip = new Siparis();
                    sip.MasaNo = (int)lvi.Tag;
                    sip.AcilisZamani = DateTime.Now;
                    lvi.Tag = sip;
                    db.AktifSiparisler.Add(sip);
                }

                SiparisForm frmSiparis = new SiparisForm(db, sip);
                frmSiparis.MasaTasindi += FrmSiparis_MasaTasindi;
                frmSiparis.ShowDialog();

                if (sip.Durum == SiparisDurum.Odendi || sip.Durum == SiparisDurum.Iptal)
                {
                    lvi.Tag = sip.MasaNo;
                    lvi.ImageKey = "bos";
                    db.AktifSiparisler.Remove(sip);
                    db.GecmisSiparisler.Add(sip);
                }
            }
        }

        private void FrmSiparis_MasaTasindi(object sender, MasaTasimaEventArgs e)
        {
            //adım1: eski masayı boşalt
            ListViewItem lviEskiMasa = null;
            foreach (ListView item in lvwMasalar.Items)
            {
                if (item.Tag== e.TasinanSiparis)
                {
                    lviEskiMasa = item;
                    break;
                }
            }
           
            //adım2: yeni masaya siparişi koy
        }

        private void tsmiGecmisSiparisler_Click(object sender, EventArgs e)
        {
            var frm = new GecmisSiparisler(db);
            frm.ShowDialog();
        }

        private void tsmiUrunler_Click(object sender, EventArgs e)
        {
            var frm = new UrunlerForm(db);
            frm.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string json = JsonConvert.SerializeObject(db);
            File.WriteAllText("veri.json", json);
        }
    }
}

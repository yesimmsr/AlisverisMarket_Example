using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlisverisMarket_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Sebzeler => Marul,Maydanoz,Havuç,Domates,Biber//KtegoriID => 1
        //Meyveler => Kiraz,Şeftali,Erik,Karpuz,Avakado,//KtegoriID => 2
        //Kuru Bakliyat => Pirinç,Bulgur,Fasulye,mercimek//KtegoriID => 3

        List<(int id, string UrunAdi, int KategoriId)> urunler = new List<(int id, string UrunAdi, int KategoriId)>()
        {
            (0, "Marul", 1),
            (1, "Maydanoz", 1),
            (2, "Havuç", 1),
            (3, "Domates",1),
            (4, "Biber", 1),
            (5, "Kiraz", 2),
            (6, "Şeftali", 2),
            (7, "Erik", 2),
            (8, "Karpuz", 2),
            (9, "Avakado", 2),
            (10, "Pirinç", 3),
            (11, "Bulgur", 3),
            (12, "Fasulye", 3),
            (13, "Mercimek", 3),
    };

        List<(int id, decimal kilogram)> orders = new List<(int id, decimal kilogram)>();

        List<(int id, decimal kilogram)> historyOrders = new List<(int id, decimal kilogram)>();


        public void FillControl()
        {
            cmbUrunler.Items.Clear();
            foreach (var urun in urunler)
            {
                cmbUrunler.Items.Add(urun.UrunAdi);
            }
            cmbUrunler.SelectedIndex = 0; //defaultta ilk index ürünü seçili gelir.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillControl();
        }


        private void cmbUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbUrunler.SelectedIndex == -1)
            {
                MessageBox.Show("Ürün seçimi yapınız.");
                cmbUrunler.Focus();
                return;
            }

            var secilenUrun = urunler[cmbUrunler.SelectedIndex];
            decimal kilogram = nuAdet.Value;

            var siparis = (secilenUrun.id, kilogram);
            orders.Add(siparis);
            FillSepet(); //ekledikten sonra sepeti günceller
        }

        public void FillSepet()
        {
            lstSepet.Items.Clear();
            foreach (var order in orders)
            {
                var urun = GetUrun(order.id);
                lstSepet.Items.Add($"{urun.UrunAdi} x {order.kilogram.ToString("N2")} kg");
            }
        }

        public (int id, string UrunAdi, int KategoriId) GetUrun(int id)
        {
            (int id, string UrunAdi, int KategoriId) returnUrun = (0, "", 0);
            foreach (var urun in urunler)
            {
                if (urun.id == id)
                    return urun;
            }
            return returnUrun;
        }

        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
            HistoryOrderAdd();

            orders.Clear();
            lstSepet.Items.Clear();

            SiparisleriDagit();
        }

        public void SiparisleriDagit()
        {
            lstSebze.Items.Clear();
            lstMeyve.Items.Clear();
            lstBakliyat.Items.Clear();

            decimal toplamSebze = 0;
            decimal toplamMeyve = 0;
            decimal toplamBakliyat = 0; 

            foreach (var order in historyOrders)
            {
                var urun = GetUrun(order.id);
                if (urun.KategoriId == 1)
                {
                    toplamSebze += order.kilogram;
                    lstSebze.Items.Add($"{urun.UrunAdi} x {order.kilogram.ToString("N2")} kg");
                }
                else if (urun.KategoriId == 2)
                {
                    toplamMeyve += order.kilogram;
                    lstMeyve.Items.Add($"{urun.UrunAdi} x {order.kilogram.ToString("N2")} kg");
                }
                else if(urun.KategoriId == 3)
                {
                    toplamBakliyat += order.kilogram;
                    lstBakliyat.Items.Add($"{urun.UrunAdi} x {order.kilogram.ToString("N2")} kg");
                }
            }

            lblMeyveToplam.Text = $"Toplam => {toplamSebze.ToString("N2")}";
            lblMeyveToplam.Text = $"Toplam => {toplamSebze.ToString("N2")}";
            lblBakliyatTopla.Text = $"Toplam => {toplamSebze.ToString("N2")}";
        }


        public void HistoryOrderAdd()
        {
            foreach (var order in orders)
            {
                historyOrders.Add(order);
            }
        }
    }
}

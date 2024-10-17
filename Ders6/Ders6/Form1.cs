using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Calisan> calisanlar=new List<Calisan>()
        {
            new Calisan(){Ad="Ahmet",Soyad="ÇALIŞKAN",Bolum="Öğretmen"},
            new Calisan(){Ad="Esma",Soyad="BAŞ",Bolum="Yazılımcı"},
            new Calisan(){Ad="Fatih",Soyad="DİYAR",Bolum="İnşaat Mühendisi"},
            new Calisan(){Ad="Aytaç",Soyad="ÖZEN",Bolum="Mubaşir"},
            new Calisan(){Ad="Kadriye",Soyad="ÖZGÜLER",Bolum="Teknisyen"}
        };



        #region DataGridView

        //DataGridView kontrolü satır ve sütunlardan oluşan tablo gösterimi sağlayan bir kontroldür.İçerisine List tipinde koleksiyonlar alır ve tablo şeklinde kullanıcıya gösterim sağlar

        //Başlıca Özellikleri
        //---------------------------
        //AllowUserToAddRows : Kullanıcın yeni bir kayıt ekleyip ekleyemeceğini belirtir
        //ALlowUserToDeleteRows : Kıllanıcının bir kayıt silip silemeyeceğini belirtir
        //Colums : Tablo içerisinde listelenecek olan sütunlar ile ilgili işlemler uygulanır
        //DataSource : GridView in bir koleksiyon ile etkileşime geçmesini sağlar
        //MultiSelect : Satır , sutünveya güclerin çoklu seçim yapmasını sağlar
        //ReadOnly : Sadece okunabilir yapar
        //Row : Satırlar ile ilgili işlemler yapmanızı sağlar
        //SelectionMode : Satır  , sutün ve hücre seçiminin türünü belirtir


        #endregion

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource= calisanlar;
        }

        private void btnSirala_Click(object sender, EventArgs e)
        {
            var siraliListe=calisanlar.OrderBy(x => x.Ad).ToList();
            dataGridView1.DataSource= siraliListe;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Seçilen hücrenin satırının index bilgisine ulaşalım
            int seciliIndex=e.RowIndex;

           // lblBilgi.Text=seciliIndex.ToString();

            string ad = dataGridView1.Rows[seciliIndex].Cells[0].Value.ToString();
            string soyad= dataGridView1.Rows[seciliIndex].Cells[1].Value.ToString();
            string bolum= dataGridView1.Rows[seciliIndex].Cells[2].Value.ToString();
            lblBilgi.Text = string.Format("{0} {1} \n{2}",ad,soyad,bolum);
        }
    }
}

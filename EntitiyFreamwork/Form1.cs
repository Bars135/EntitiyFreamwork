using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitiyFreamwork
{
    public partial class Form1 : Form
    {
        private void UrunList()
        {
            dataGridView1.DataSource = db.Urunler.ToList();
        }
        public Form1()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             Entity Framework orm modelleme 3 farklı yöntem kullanılmaktadır 
            databese first
            model first
            code first

            biz sıklıkla database first veya code first kullanacağız model firs yaklaşımı tercih edilmemektedir geenellikle mysql gibi database bağlantısı işlelerinde kullanılmaktadır 
            Database first yeni ir entity model oluşturmak için adından da anlaşılacağı üzere önceliği veritababnı olarak görür yeni modeli hazırda buluna bir veri tabanı oluşturur burada esansen var olan veri tabanı üzerinden işlem yapmaktadır 
            Code first mimarisi ise olmayan bir database proje üzerinden geliştiririz yani database işlemlerimizin tamamını tablolaştırmaya kadar proje üzerinden yaparsız hangisini tercih edeceğiz eğer database var ise hazırda database first mimarisini kullanırız eğer yo ise databsemiz proje üzerinden bu işlemleri gerçekleştirebiliriz 
             
             */
            dataGridView1.DataSource = db.Urunler.ToList();
            //ColumnsPrivate(2,3,7,8,99,10,11,12);


            var list = db.Urunler.Select(x => x.UrunAdi).ToList();
            comboBox1.DataSource = list;


        }
        public void ColumnsPrivate(params int[] dizi) //Eğer dizi boyutunu bilmiyorsak Params kullanılır
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                int deger = dizi[i];
                dataGridView1.Columns[i].Visible = false;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urunler urun = new Urunler();
            urun.UrunAdi = txtUrunadi.Text;
            urun.BirimFiyati = Convert.ToDecimal(txtFiyat.Text);
            urun.HedefStokDuzeyi = Convert.ToInt16(txtStok.Text);
            db.Urunler.Add(urun);
            int etki = db.SaveChanges();
            if (etki > 0)
            {

                MessageBox.Show("Urun Eklendi LOOOOOOO");
                UrunList();
            }
            else
            {

                MessageBox.Show("Hata Çıktı Geri Dön Debuga");
                UrunList();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunadi.Text = dataGridView1.CurrentRow.Cells["UrunAdi"].Value.ToString();
            txtUrunadi.Tag = dataGridView1.CurrentRow.Cells["UrunId"].Value.ToString();
            txtFiyat.Text = dataGridView1.CurrentRow.Cells["BirimFiyati"].Value.ToString();
            txtStok.Text = dataGridView1.CurrentRow.Cells["HedefStokDüzeyi"].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtUrunadi.Text);
            var x = db.Urunler.Find(id);
            x.UrunAdi = txtUrunadi.Text;
            x.HedefStokDuzeyi = short.Parse(txtStok.Text);
            x.BirimFiyati = decimal.Parse(txtFiyat.Text);
            int etki = db.SaveChanges();
            if (etki > 0)
            {
                MessageBox.Show("Değişiklikler Kaydediildi");
                UrunList();
            }
            else
            {
                MessageBox.Show("Hata Var Hataaaaa");
                dataGridView1.DataSource = db.Urunler.ToList();
            }
        }
    }
}

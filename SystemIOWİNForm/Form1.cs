using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemIOWİNForm
{
    public partial class Form1 : Form
    {
        DataIslemleri dataIslemleri;
        List<Personel> personels;
        
        public Form1()
        {
            InitializeComponent();
            dataIslemleri = new DataIslemleri();
          

        }

        public void btnPersonelGetir_Click(object sender, EventArgs e)
        {
          
         personels = dataIslemleri.PersonelGetir(150);
            lstPersonel.DataSource = personels;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lstPersonel_MouseClick(object sender, MouseEventArgs e)
        {
            //Personel secilenpersonel = (Personel)lstPersonel.SelectedItem;

            isimbox.Text = personels[lstPersonel.SelectedIndex].isim;
            soyisimbox.Text = personels[lstPersonel.SelectedIndex].soyisim;
            emailbox.Text = personels[lstPersonel.SelectedIndex].email;
            firmabox.Text = personels[lstPersonel.SelectedIndex].firmaAdi;
            ulkebox.Text = personels[lstPersonel.SelectedIndex].ulke;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataIslemleri.PersonelKayddet("c:\\Udemy", personels);
        }
    }
}

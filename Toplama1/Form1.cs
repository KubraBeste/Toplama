using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toplama1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void bildirimYaz(string mesaj)
        {
            lvbildirim.Items.Add(mesaj);
        }
        private int topla(int ikinciSayi, int birinciSayi)
        {
            return ikinciSayi + birinciSayi;
            
        }
        private Boolean Dogrula()
        {
            try
            {
                Convert.ToInt32(txtbirincisayi.Text);
                Convert.ToInt32(txtikincisayi.Text);
                return true;
            }
            catch(Exception e)
            {
                bildirimYaz("Başarısız: " + e.Message);
                return false;
            }

        }
        
        private void EkranıHazirla(bool toplamBasarili = false)
        {
                if (!toplamBasarili)
                txtbirincisayi.Text = "0";
                txtikincisayi.Text = "0";
                txtbirincisayi.Focus();
            
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            EkranıHazirla();
        }
        private void Btntoplama_Click(object sender, EventArgs e)
        {
           bool dogrula = Dogrula();
           if (dogrula)
           {
                int sonuç;
                sonuç = topla(Convert.ToInt32(txtbirincisayi.Text),
                              Convert.ToInt32(txtikincisayi.Text));
                txtsonuc.Text = sonuç.ToString();
                bildirimYaz("Toplama işlemi başarılı: " + txtsonuc.Text);

            }
           else
           {
                MessageBox.Show("Girdiğiniz değerler hatalı!!!!");
                EkranıHazirla(dogrula);
           }
           
           
        }

        

        private void Txtbirincisayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar) 
                )
                e.Handled = true;
        }

        private void Txtikincisayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
               char.IsLetter(e.KeyChar) ||
               char.IsSymbol(e.KeyChar) ||
               char.IsWhiteSpace(e.KeyChar) ||
               char.IsPunctuation(e.KeyChar)
               )
                e.Handled = true;
        }

        private void Btngeri_Click(object sender, EventArgs e)
        {
            tabgenel.SelectedTab = tabtoplama;
        }

        private void Btntemizle_Click(object sender, EventArgs e)
        {
            lvbildirim.Items.Clear();
        }
        private void Btnileri_Click(object sender, EventArgs e)
        {
            tabgenel.SelectedTab = tabbildirim;
        }
    }
}

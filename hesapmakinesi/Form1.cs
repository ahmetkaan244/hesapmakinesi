using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakinesi
{
    public partial class Form1 : Form
    {
        string islem;
        double ilksayi;
        double ikincisayi;
        double sonuc;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void islemTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void sayi0Btn_Click(object sender, EventArgs e)
        {
            if (islemTxt.Text == "0" | islemTxt.Text == null)
            {
                islemTxt.Text = "0";
            }
            else
            {
                islemTxt.Text += "0";
            }
        }

        private void sayi1Btn_Click(object sender, EventArgs e)
        {
            if (islemTxt.Text == "0" | islemTxt.Text == null)
            {
                islemTxt.Text = "1";
            }
            else
            {
                islemTxt.Text += "1";
            }
        }

        private void sayi2Btn_Click(object sender, EventArgs e)
        {
            if (islemTxt.Text == "0" | islemTxt.Text == null)
            {
                islemTxt.Text = "2";
            }
            else
            {
                islemTxt.Text += "2";
            }
        }
        private void sayi3Btn_Click(object sender, EventArgs e)
        {
            if (islemTxt.Text == "0" | islemTxt.Text == null)
            {
                islemTxt.Text = "3";
            }
            else
            {
                islemTxt.Text += "3";
            }
        }
        private void sayi4Btn_Click(object sender, EventArgs e)
        {
            if (islemTxt.Text == "0" | islemTxt.Text == null)
            {
                islemTxt.Text = "4";
            }
            else
            {
                islemTxt.Text += "4";
            }
        }

        private void sayi5Btn_Click(object sender, EventArgs e)
        {
            if (islemTxt.Text == "0" | islemTxt.Text == null)
            {
                islemTxt.Text = "5";
            }
            else
            {
                islemTxt.Text += "5";
            }
        }

        private void sayi6Btn_Click(object sender, EventArgs e)
        {
            if (islemTxt.Text == "0" | islemTxt.Text == null)
            {
                islemTxt.Text = "6";
            }
            else
            {
                islemTxt.Text += "6";
            }
        }

        private void sayi7Btn_Click(object sender, EventArgs e)
        {
            if (islemTxt.Text == "0" | islemTxt.Text == null)
            {
                islemTxt.Text = "7";
            }
            else
            {
                islemTxt.Text += "7";
            }
        }

        private void sayi8Btn_Click(object sender, EventArgs e)
        {
            if (islemTxt.Text == "0" | islemTxt.Text == null)
            {
                islemTxt.Text = "8";
            }
            else
            {
                islemTxt.Text += "8";
            }
        }

        private void sayi9Btn_Click(object sender, EventArgs e)
        {
            if (islemTxt.Text == "0" | islemTxt.Text == null)
            {
                islemTxt.Text = "9";
            }
            else
            {
                islemTxt.Text += "9";
            }
        }



        private void bolBtn_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(islemTxt.Text);
            islemTxt.Text = null;
            islem = "/"; 
        }

        private void carpBtn_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(islemTxt.Text);
            islemTxt.Text = null;
            islem = "*"; 
        }

        private void cikarBtn_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(islemTxt.Text);
            islemTxt.Text = null;
            islem = "-"; 
        }

        private void toplaBtn_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(islemTxt.Text);
            islemTxt.Text = null;
            islem = "+"; 
        }
      
        private void sonucBtn_Click(object sender, EventArgs e)
        {
           
            ikincisayi = Convert.ToDouble(islemTxt.Text);
            if (islem == "+")
            {
                sonuc = ilksayi + ikincisayi;
                islemTxt.Text = Convert.ToString(sonuc);
            }
            if (islem == "-")
            {
                sonuc = ilksayi - ikincisayi;
                islemTxt.Text = Convert.ToString(sonuc);
            }
            if (islem == "/")
            {
                sonuc = ilksayi / ikincisayi;
                islemTxt.Text = Convert.ToString(sonuc);
            }
            if (islem == "*")
            {
                sonuc = ilksayi * ikincisayi;
                islemTxt.Text = Convert.ToString(sonuc);
            }
        }
        public void delete_Click(object sender, EventArgs e)
        {
            islemTxt.Clear();
            ikincisayi = 0;
            sonuc = 0;
            ilksayi = 0;

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPTB2
{
    public partial class frmGPTB2 : Form
    {
        public frmGPTB2()
        {
            InitializeComponent();
        }

        private void frmGPTB2_Load(object sender, EventArgs e)
        {
            //Các lệnh thực hiện khi form được load 
        }
        private void btGiaiPhuongTrinh_Click(object sender, EventArgs e)
        {
            float a, b, c, delta, x1, x2;
            //Xu ly nhap cac he so a, b, c
            if (!float.TryParse(txtHeSoa.Text, out a))
            {
                MessageBox.Show("He so a nhap chua dung");
                txtHeSoa.Focus();
                return;
            }
            if (!float.TryParse(txtHeSob.Text, out b))
            {
                MessageBox.Show("He so b nhap chua dung");
                txtHeSob.Focus();
                return;
            }
            if (!float.TryParse(txtHeSoc.Text, out c))
            {
                MessageBox.Show("He so c nhap chua dung");
                txtHeSoc.Focus();
                return;
            }
            //Xet dieu kien ton tai phuong trinh bac 2
            if (a == 0)
            {
                MessageBox.Show("Day khong phai phuong trinh bac 2");
                txtHeSoa.Focus();
                return;
            }
            //Tinh delta
            delta = b * b - 4 * a * c;
            //Xet cac nghiem cua phuong trinh
            if (delta < 0)
            {
                txtKetQua.Text = "Phuong trinh vo nghiem";
            }
            else if (delta == 0)
            {
                x1 = x2 = (-b) / (2 * a);
                txtKetQua.Text = "Phuong trinh co nghiem kep x1=x2= " + x1.ToString();
            }
            else
            {
                x1 = (float)((-b) - Math.Sqrt(delta)) / (2 * a);
                x2 = (float)((-b) + Math.Sqrt(delta)) / (2 * a);
                txtKetQua.Text = "Phuong trinh co 2 nghiem phan biet: \r\nx1=" + x1.ToString() +
                    "\r\nx2=" + x2.ToString();
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1._0._1
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool _ekranTemizlenecekMi;
        private int _ilkSayi;
        public Form1()
        {
            InitializeComponent();
 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "6";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "8";
        }

        private void btn7_Click_1(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "7";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "0";
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(ekranLabel.Text);
            int sonuc;
            switch (_islem)
            {
                case '+':
                    sonuc = _ilkSayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilkSayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilkSayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilkSayi / ikinciSayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }
            ekranLabel.Text = Convert.ToString(sonuc);
        }

        private void btnCıkar_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "0";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(this.ActiveControl.GetType() == typeof(Button))
                ekranLabel.Focus();

            if (e.KeyCode == Keys.NumPad1)
            {
                btn1_Click(null,null);
            }
            if (e.KeyCode == Keys.NumPad2)
            {
                btn2_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad3)
            {
                btn3_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad4)
            {
                btn4_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad5)
            {
                btn5_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad6)
            {
                btn6_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad7)
            {
                btn7_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad8)
            {
                btn8_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad9)
            {
                btn9_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad0)
            {
                btn0_Click(null, null);
            }
            if (e.KeyCode == Keys.Add  ) 
            {
                btnTopla_Click(null, null);
            }
            if (e.KeyCode == Keys.Subtract)
            {
                btnCıkar_Click(null, null);
            }
            if (e.KeyCode == Keys.Multiply)
            {
                btnCarp_Click(null, null);
            }
            if (e.KeyCode == Keys.Divide)
            {
                btnBol_Click(null, null);
            }
            if (e.KeyCode == Keys.Delete)
            {
                btnC_Click(null,null);
            }
            if (e.KeyCode == Keys.Return)
            {
                //btnSonuc_Click(null,null);
                btnSonuc.PerformClick();    
            }
            this.Focus();
        }

        private void btn7_Click(object value1, object value2)
        {
            throw new NotImplementedException();
        }
        
    }
}

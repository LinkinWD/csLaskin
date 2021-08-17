using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laskin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double total = 0;
        string current = "";
        string laskutoimitus = "";
        Boolean yhtäkuin = false;

        public void syöte(string lisäys)
        {
           
                if (current != "0" && yhtäkuin == false)
                {
                    current = current + lisäys;
                    txt_current.Text = current;
                } else if (current == "0" && lisäys != "." && yhtäkuin == false) {
                    current = lisäys;
                    txt_current.Text = current;

                }
            
        }
        public void ekaLuku()
        {
            txt_total.Text = current;
            total = Convert.ToDouble(current);
            current = "0";
            txt_current.Text = current;
        }
        
        public void lToimitus()
        {
            if(laskutoimitus == "plus")
            {
                total = total + Convert.ToDouble(current);
                current = "0";
                txt_total.Text = total.ToString();
                txt_current.Text = current;
            }
            if (laskutoimitus == "minus")
            {
                total = total - Convert.ToDouble(current);
                current = "0";
                txt_total.Text = total.ToString();
                txt_current.Text = current;
            }
            if (laskutoimitus == "kerro")
            {
                total = total * Convert.ToDouble(current);
                current = "0";
                txt_total.Text = total.ToString();
                txt_current.Text = current;
            }
            if (laskutoimitus == "jaa")
            {
                total = total / Convert.ToDouble(current);
                current = "0";
                txt_total.Text = total.ToString();
                txt_current.Text = current;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_current.Text = "0";




            
        }
        // Syöte numerot tässä aluksi
        private void btn_1_Click(object sender, EventArgs e)
        {
            
            syöte("1");
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            syöte("2");
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            syöte("3");
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            syöte("4");
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            syöte("5");
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            syöte("6");
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            syöte("7");
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            syöte("8");
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            syöte("9");
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            syöte("0");
        }
        // syötenumerot loppuu, erikoismerkit alkaa
        private void btn_clear_Click(object sender, EventArgs e)
        {
            if(current.Length > 1)
            {
                current = current.Remove(current.Length - 1);
                txt_current.Text = current;
            } else
            {
                current = "0";
                txt_current.Text = current;
                yhtäkuin = false;
            }
           
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            if(current.IndexOf(",") == -1 && yhtäkuin == false)
            {
                syöte(",");
            } 
        }

        private void btn_allClear_Click(object sender, EventArgs e)
        {
            total = 0;
            current = "0";
            txt_current.Text = "0";
            txt_total.Text = "";
            yhtäkuin = false;
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            
            if(total == 0)
            {
                ekaLuku();
            } else
            {
                lToimitus();
                yhtäkuin = false;
            }
            laskutoimitus = "plus";
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            
            if (total == 0)
            {
                ekaLuku();
            }
            else
            {
                lToimitus();
                yhtäkuin = false;
            }
            laskutoimitus = "minus";
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {

            if (total == 0)
            {
                ekaLuku();
                
            }
            else
            {
                lToimitus();
                yhtäkuin = false;
            }
            laskutoimitus = "kerro";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (total == 0)
            {
                ekaLuku();
                
            }
            else
            {
                lToimitus();
                yhtäkuin = false;
            }
            laskutoimitus = "jaa";
        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            if(total != 0)
            {
                lToimitus();
                laskutoimitus = "";
                yhtäkuin = true;
            }
        }
    }
}

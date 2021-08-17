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

        public void syöte(string lisäys)
        {
            if (current != "0")
            {
                current = current + lisäys;
                txt_current.Text = current;
            } else if(current == "0" && lisäys != ".") {
                current = lisäys;
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
            }
           
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            if(current.IndexOf(".") == -1)
            {
                syöte(".");
            } 
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinklabelVScroll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if(vScrollBar1.Value>0 && vScrollBar1.Value<=25)
            {
                this.BackColor = Color.DeepSkyBlue;
                linkLabel1.Visible = true;


            }
            else
            {
                linkLabel1.Visible = false;
            }

            if(vScrollBar1.Value>25 && vScrollBar1.Value<=50)
            {
                this.BackColor = Color.SpringGreen;
                linkLabel2.Visible = true;
            }
            else
            {
                linkLabel2.Visible = false;
            }

            if(vScrollBar1.Value>50 && vScrollBar1.Value<=75)
            {
                this.BackColor = Color.Gold;
                linkLabel3.Visible = true;
            }
            else
            {
                linkLabel3.Visible = false;
            }

            if(vScrollBar1.Value>75 && vScrollBar1.Value<=100)
            {
                this.BackColor = Color.Indigo;
                linkLabel4.Visible = true;
            }
            else
            {
                linkLabel4.Visible=false;
            }
            
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel1.Visible = false;
            linkLabel2.Visible = false;
            linkLabel3.Visible = false;
            linkLabel4.Visible = false;
          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Soru1 frm = new Soru1();
            frm.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Soru2 frm = new Soru2();
            frm.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Soru3 frm = new Soru3();
            frm.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Soru4 frm = new Soru4();
            frm.Show();
        }

        
    }
}

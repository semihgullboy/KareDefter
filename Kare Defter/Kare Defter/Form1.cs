using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kare_Defter
{
    public partial class Form1 : Form
    {
        int Alan, puan = 0;
        bool hamle = false;

        public Form1()
        {
            InitializeComponent();
            buttonolusturma();
        }

         private void buttonolusturma()
        {
            puan = 0;
            label1.Text = "Puan : 0";
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.ColumnCount = 9;
            Alan = 81;
            for (int i = 0; i < Alan; i++)
            {
                Button button = new Button();
                button.Size = new Size(50, 50);
                button.Tag = 0;
                button.Click += Button_Click;
                tableLayoutPanel1.Controls.Add(button);
                button.BackColor = Color.White;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;
            puan++;
            label1.Text = "Puan : " + puan;
            tiklanan.Text = puan.ToString();
            Sifirla();
            for (int i = 0; i < Alan; i++)
            {
                tableLayoutPanel1.Controls[i].Enabled = false;
            }
            tiklanan.Enabled = false;
            tiklanan.Tag = 1;
            Hamleler(tiklanan);
            if (!hamle)
            {
                if (puan == Alan)
                {
                    MessageBox.Show("Kazandınız  \n Puanınız : 81" );
                }
                else
                {
                    MessageBox.Show(" Kaybettiniz  \n Puanınız :" + puan);
                }
            }
        }

        public void Sifirla()
        {
            for (int i = 0; i < Alan; i++)
            {
                tableLayoutPanel1.Controls[i].BackColor = Color.White;
            }
            hamle = false;
        }

        public void Hamleler(Button btn)
        {
            int i;
            for (i = 0; i < Alan; i++)
            {
                if (puan.ToString() == tableLayoutPanel1.Controls[i].Text)
                    break;
            }
            if (0 <= (i - (2 * tableLayoutPanel1.ColumnCount) + 1) && (tableLayoutPanel1.ColumnCount - 1) - (i % tableLayoutPanel1.ColumnCount) >= 1 && tableLayoutPanel1.Controls[(i - (2 * tableLayoutPanel1.ColumnCount) + 1)].Tag.ToString() == 0.ToString())
            {
                tableLayoutPanel1.Controls[i - (2 * tableLayoutPanel1.ColumnCount) + 1].Enabled = true;
                tableLayoutPanel1.Controls[i - (2 * tableLayoutPanel1.ColumnCount) + 1].BackColor = Color.Orange;
                hamle = true;
            }
            if (0 <= (i - (2 * tableLayoutPanel1.ColumnCount) - 1) && (i % tableLayoutPanel1.ColumnCount) >= 1 && tableLayoutPanel1.Controls[(i - (2 * tableLayoutPanel1.ColumnCount) - 1)].Tag.ToString() == 0.ToString())
            {
                tableLayoutPanel1.Controls[i - (2 * tableLayoutPanel1.ColumnCount) - 1].Enabled = true;
                tableLayoutPanel1.Controls[i - (2 * tableLayoutPanel1.ColumnCount) - 1].BackColor = Color.Orange;
                hamle = true;
            }
            if ((i + (2 * tableLayoutPanel1.ColumnCount) + 1) < tableLayoutPanel1.ColumnCount * tableLayoutPanel1.ColumnCount && (tableLayoutPanel1.ColumnCount - 1) - (i % tableLayoutPanel1.ColumnCount) >= 1 && tableLayoutPanel1.Controls[(i + (2 * tableLayoutPanel1.ColumnCount) + 1)].Tag.ToString() == 0.ToString())
            {
                tableLayoutPanel1.Controls[i + (2 * tableLayoutPanel1.ColumnCount) + 1].Enabled = true;
                tableLayoutPanel1.Controls[i + (2 * tableLayoutPanel1.ColumnCount) + 1].BackColor = Color.Orange;
                hamle = true;
            }
            if ((i + (2 * tableLayoutPanel1.ColumnCount) - 1) < tableLayoutPanel1.ColumnCount * tableLayoutPanel1.ColumnCount && (i % tableLayoutPanel1.ColumnCount) >= 1 && tableLayoutPanel1.Controls[(i + (2 * tableLayoutPanel1.ColumnCount) - 1)].Tag.ToString() == 0.ToString())
            {
                tableLayoutPanel1.Controls[i + (2 * tableLayoutPanel1.ColumnCount) - 1].Enabled = true;
                tableLayoutPanel1.Controls[i + (2 * tableLayoutPanel1.ColumnCount) - 1].BackColor = Color.Orange;
                hamle = true;
            }
            if (2 <= (i % tableLayoutPanel1.ColumnCount) && 0 <= (i - tableLayoutPanel1.ColumnCount - 2) && tableLayoutPanel1.Controls[(i - tableLayoutPanel1.ColumnCount - 2)].Tag.ToString() == 0.ToString())
            {
                tableLayoutPanel1.Controls[i - tableLayoutPanel1.ColumnCount - 2].Enabled = true;
                tableLayoutPanel1.Controls[i - tableLayoutPanel1.ColumnCount - 2].BackColor = Color.Orange;
                hamle = true;
            }
            if ((tableLayoutPanel1.ColumnCount - 1) - (i % tableLayoutPanel1.ColumnCount) >= 2 && 0 <= (i - tableLayoutPanel1.ColumnCount + 2) && tableLayoutPanel1.Controls[(i - tableLayoutPanel1.ColumnCount + 2)].Tag.ToString() == 0.ToString())
            {
                tableLayoutPanel1.Controls[i - tableLayoutPanel1.ColumnCount + 2].Enabled = true;
                tableLayoutPanel1.Controls[i - tableLayoutPanel1.ColumnCount + 2].BackColor = Color.Orange;
                hamle = true;
            }
            if (2 <= (i % tableLayoutPanel1.ColumnCount) && tableLayoutPanel1.ColumnCount * tableLayoutPanel1.ColumnCount > (i + tableLayoutPanel1.ColumnCount - 2) && tableLayoutPanel1.Controls[(i + tableLayoutPanel1.ColumnCount - 2)].Tag.ToString() == 0.ToString())
            {
                tableLayoutPanel1.Controls[i + tableLayoutPanel1.ColumnCount - 2].Enabled = true;
                tableLayoutPanel1.Controls[i + tableLayoutPanel1.ColumnCount - 2].BackColor = Color.Orange;
                hamle = true;
            }
            if ((tableLayoutPanel1.ColumnCount - 1) - (i % tableLayoutPanel1.ColumnCount) >= 2 && tableLayoutPanel1.ColumnCount * tableLayoutPanel1.ColumnCount > (i + tableLayoutPanel1.ColumnCount + 2) && tableLayoutPanel1.Controls[(i + tableLayoutPanel1.ColumnCount + 2)].Tag.ToString() == 0.ToString())
            {
                tableLayoutPanel1.Controls[i + tableLayoutPanel1.ColumnCount + 2].Enabled = true;
                tableLayoutPanel1.Controls[i + tableLayoutPanel1.ColumnCount + 2].BackColor = Color.Orange;
                hamle = true;
            }
        }

    }
}

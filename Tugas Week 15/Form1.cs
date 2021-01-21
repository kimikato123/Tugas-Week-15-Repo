using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Week_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string[] makanan = new string[] { "mie Instan", "Telor", "Roti", "Keju", "Daging giling" };
        public string[] minuman = new string[] { "Susu Sapi", "Kopi", "Teh", "Bir"};
        public string[] makanan1 = new string[200];
        public string[] minuman1 = new string[200];
        public int countermakanan = 0;
        public int counterminuman = 0;
        
        public void buttoninput_Click(object sender, EventArgs e)
        {
            if (textBoxnama.Text == "")
            {
                MessageBox.Show("tolong isi nama item");
            }
            else 
            {
                if (radioButtonmakanan.Checked == true)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (textBoxnama.Text != makanan[i])
                        {
                            for (int j = 0; j <= countermakanan; j++)
                            {
                                if (textBoxnama.Text != makanan1[j])
                                {
                                    listBoxkiri.Items.Add(textBoxnama.Text);
                                    makanan1[countermakanan] = textBoxnama.Text;
                                    countermakanan++;
                                }
                                else
                                {
                                    MessageBox.Show("data gagal diinputkan");
                                    textBoxnama.Text = "";
                                    radioButtonmakanan.Checked = false;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("data gagal diinputkan");
                            textBoxnama.Text = "";
                            radioButtonmakanan.Checked = false;
                        }
                    }
                }
                else if (radioButtonminuman.Checked == true)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (textBoxnama.Text != minuman[i])
                        {
                            for (int j = 0; j <= counterminuman; j++)
                            {
                                if (textBoxnama.Text != minuman1[j])
                                {
                                    listBoxkiri.Items.Add(textBoxnama.Text);
                                    minuman1[counterminuman] = textBoxnama.Text;
                                    counterminuman++;
                                }
                                else
                                {
                                    MessageBox.Show("data gagal diinputkan");
                                    textBoxnama.Text = "";
                                    radioButtonminuman.Checked = false;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("data gagal diinputkan");
                            textBoxnama.Text = "";
                            radioButtonminuman.Checked = false;
                        }
                    }
                }
            }
        }

        private void buttonpanah_Click(object sender, EventArgs e)
        {
            foreach (var items in listBoxkiri.SelectedItems)
            {
                listBoxkanan.Items.Add(items);
            }
            string Temp1 = "";
            string Temp2 = "";

            for (int i = 0; i <= listBoxkanan.Items.Count - 2; i++)
            {
                Temp1 = (string)listBoxkanan.Items[i];

                for (int j = (listBoxkanan.Items.Count - 1); j >= (i + 1); j += -1)
                {
                    Temp2 = (string)listBoxkanan.Items[j];

                    if (Temp1 == Temp2)
                    {
                        listBoxkanan.Items.RemoveAt(j);
                    }
                }
            }
        }

        private void listBoxkiri_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBoxmakanan_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonsilang_Click(object sender, EventArgs e)
        {
           if (listBoxkanan.SelectedIndex != -1)
            {
                while(listBoxkanan.SelectedItems.Count != 0)
                {
                    listBoxkanan.Items.Remove(listBoxkanan.SelectedItems[0]);
                }
            }
        }
    }
}

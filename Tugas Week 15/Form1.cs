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
        public string[] makanan = new string[] { "Mie Instan", "Telor", "Roti ", "Keju", "Daging Giling" };
        public string[] minuman = new string[] { "Susu Sapi", "Kopi", "Teh", "Bir"};
        public string[] makanan1 = new string[200];
        public string[] minuman1 = new string[200];
        public int countermakanan = 0;
        public int counterminuman = 0;
        public bool tes1 = false;
        public bool tes2 = false;
        public bool tes3 = false;
        public bool tes4 = false;

        public void buttoninput_Click(object sender, EventArgs e)
        {
            if (textBoxnama.Text == "")
            {
                MessageBox.Show("tolong isi nama item");
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    if (textBoxnama.Text == minuman[i])
                    {
                        tes1 = true;
                    }
                    else
                    {
                       
                    }
                }
                for (int j = 0; j <= counterminuman; j++)
                {

                    if (textBoxnama.Text == minuman1[j])
                    {
                        tes2 = true;
                    }
                    else
                    {
                        
                    }
                }
                for (int k = 0; k < 5; k++)
                {

                    if (textBoxnama.Text == makanan[k])
                    {
                        tes3 = true;
                    }
                    else
                    {                   

                    }
                }
                for (int l = 0; l <= countermakanan; l++)
                {
                    if (textBoxnama.Text == makanan1[l])
                    {
                        tes4 = true;
                    }
                    else
                    {
                        
                    }
                }
            }
            if (tes1 == false && tes2 == false && tes3 == false && tes4 == false)
            {
                if (radioButtonmakanan.Checked == true)
                {
                    listBoxkiri.Items.Add(textBoxnama.Text);
                    makanan1[countermakanan] = textBoxnama.Text;
                    countermakanan++;
                }
                if (radioButtonminuman.Checked == true)
                {
                    listBoxkiri.Items.Add(textBoxnama.Text);
                    minuman1[counterminuman] = textBoxnama.Text;
                    counterminuman++;
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
            if(checkBoxmakanan.Checked == true)
            {
                for (int i = 0; i < listBoxkiri.Items.Count; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (listBoxkiri.Items[i].ToString() == makanan[j])
                        {
                            listBoxkiri.SetSelected(i, true);
                        }
                        else
                        {
                            for (int k = 0; k < countermakanan; k++)
                            {
                                if (listBoxkiri.Items[i].ToString() == makanan1[k])
                                {
                                    listBoxkiri.SetSelected(i, true);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < listBoxkiri.Items.Count; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (listBoxkiri.Items[i].ToString() == makanan[j])
                        {
                            listBoxkiri.SetSelected(i, false);
                        }
                        else
                        {
                            for (int k = 0; k < countermakanan; k++)
                            {
                                if (listBoxkiri.Items[i].ToString() == makanan1[k])
                                {
                                    listBoxkiri.SetSelected(i, false);
                                }
                            }
                        }
                    }
                }
            }
            
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

        private void checkBoxminuman_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxminuman.Checked == true)
            {
                for (int i = 0; i < listBoxkiri.Items.Count; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (listBoxkiri.Items[i].ToString() == minuman[j])
                        {
                            listBoxkiri.SetSelected(i, true);
                        }
                        else
                        {
                            for (int k = 0; k < countermakanan; k++)
                            {
                                if (listBoxkiri.Items[i].ToString() == minuman1[k])
                                {
                                    listBoxkiri.SetSelected(i, true);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < listBoxkiri.Items.Count; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (listBoxkiri.Items[i].ToString() == minuman[j])
                        {
                            listBoxkiri.SetSelected(i, false);
                        }
                        else
                        {
                            for (int k = 0; k < countermakanan; k++)
                            {
                                if (listBoxkiri.Items[i].ToString() == minuman1[k])
                                {
                                    listBoxkiri.SetSelected(i, false);
                                }
                            }
                        }
                    }
                }
            }
           
        }
    }
}

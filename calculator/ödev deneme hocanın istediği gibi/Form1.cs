using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev_deneme_hocanın_istediği_gibi
{
    public partial class Form1 : Form
    {
        double ilksayi;
        string islem;
        public Form1()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (islem == "+")
            {

                label2.Text = ilksayi + Double.Parse(label1.Text) + "+";
                ilksayi = ilksayi + Double.Parse(label1.Text);
                label1.Text = "0";

            }
            else
            {
                if (label1.Text == "")
                {
                    label2.Text = label2.Text + "+";

                }
                else
                {
                    ilksayi = Convert.ToDouble(label1.Text);
                    label2.Text = label1.Text + "+";
                }


                label1.Text = "0";
            }


            islem = "+";

        }
        private void button24_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + label1.Text;
            double ikincisayi;
            double sonuc;
            ikincisayi = Convert.ToDouble(label1.Text);
            if (islem == "+")
            {
                sonuc = (ilksayi + ikincisayi);
                label2.Text = Convert.ToString(sonuc);
                label1.Text = "";
                ilksayi = sonuc;
                islem = "";
            }
            if (islem == "-")
            {
                sonuc = (ilksayi - ikincisayi);
                label2.Text = Convert.ToString(sonuc);
                label1.Text = "";
                ilksayi = sonuc;
                islem = "";
            }
            if (islem == "*")
            {
                sonuc = (ilksayi * ikincisayi);
                label2.Text = Convert.ToString(sonuc);
                label1.Text = "";
                ilksayi = sonuc;
                islem = "";
            }
            if (islem == "/")
            {
                sonuc = (ilksayi / ikincisayi);
                label2.Text = Convert.ToString(sonuc);
                label1.Text = "";
                ilksayi = sonuc;
                islem = "";
            }
            if (islem == "%")
            {
                sonuc = (ilksayi * ikincisayi/100);
                label2.Text = Convert.ToString(sonuc);
                label1.Text = "";
                ilksayi = sonuc;
                islem = "";
            }


        }



        private void button16_Click(object sender, EventArgs e)
        {
            if (islem == "/")
            {

                label2.Text = ilksayi / Double.Parse(label1.Text) + "/";
                ilksayi = ilksayi / Double.Parse(label1.Text);
                label1.Text = "0";

            }
            else
            {
                if (label1.Text == "")
                {
                    label2.Text = label2.Text + "/";

                }
                else
                {
                    ilksayi = Convert.ToDouble(label1.Text);
                    label2.Text = label1.Text + "/";
                }


                label1.Text = "0";
            }


            islem = "/";

        }

        private void sayibut(object sender, EventArgs e)
        {
            Button tiklanan = sender as Button;
            if (label1.Text != "0")
            {

                label1.Text = label1.Text + tiklanan.Text;
            }
            else
            {
                label1.Text = "";
                label1.Text = tiklanan.Text;

            }
        }

        private void eksi_Click(object sender, EventArgs e)
        {
            if (islem == "-")
            {

                label2.Text = ilksayi - Double.Parse(label1.Text) + "-";
                ilksayi = ilksayi - Double.Parse(label1.Text);
                label1.Text = "0";

            }
            else
            {
                if (label1.Text == "")
                {
                    label2.Text = label2.Text + "-";

                }
                else
                {
                    ilksayi = Convert.ToDouble(label1.Text);
                    label2.Text = label1.Text + "-";
                }


                label1.Text = "0";
            }


            islem = "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (islem == "*")
            {

                label2.Text = ilksayi * Double.Parse(label1.Text) + "*";
                ilksayi = ilksayi * Double.Parse(label1.Text);
                label1.Text = "0";

            }
            else
            {
                if (label1.Text == "")
                {
                    label2.Text = label2.Text + "*";

                }
                else
                {
                    ilksayi = Convert.ToDouble(label1.Text);
                    label2.Text = label1.Text + "*";
                }


                label1.Text = "0";
            }


            islem = "*";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (islem == "%")
            {

                label2.Text = ilksayi * Double.Parse(label1.Text)/100 + "%";
                ilksayi = ilksayi * Double.Parse(label1.Text)/100;
                label1.Text = "0";

            }
            else
            {
                if (label1.Text == "")
                {
                    label2.Text = label2.Text + "%";

                }
                else
                {
                    ilksayi = Convert.ToDouble(label1.Text);
                    label2.Text = label1.Text + "%";
                }


                label1.Text = "0";
            }


            islem = "%";
        }

        private void button19_Click(object sender, EventArgs e)
        {
           
            
                if (label1.Text == "")
                {
                   var karekok = Math.Sqrt(Double.Parse(label2.Text));
                   label2.Text = Convert.ToString(karekok);
                ilksayi = karekok;

                }
                else
                {
                    
                    var karekok = Math.Sqrt(Convert.ToDouble(label1.Text));
                     
                    label1.Text = Convert.ToString(karekok);
                    
                }


                
            


            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text="0";
            label2.Text="0";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text== "")
            comboBox1.Items.Add(label1.Text);
            else
            {
               var memory =Convert.ToString (Convert.ToDouble(comboBox1.SelectedItem)+Convert.ToDouble(label1.Text));
               comboBox1.Items.Add(memory);
               comboBox1.Items.Remove(comboBox1.SelectedItem);
               comboBox1.Text=memory;
               


            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
                comboBox1.Items.Add("-"+label1.Text);
            else
            {
                var memory = Convert.ToString(Convert.ToDouble(comboBox1.SelectedItem) - Convert.ToDouble(label1.Text));
                comboBox1.Items.Add(memory);
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                comboBox1.Text = memory;



            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            label1.Text =  comboBox1.Text;
        }

        private void button26_Click(object sender, EventArgs e)
        {   if (label1.Text.Contains(","))
            {

            }
            else
                    {
                    label1.Text = label1.Text+",";
                    }
            
        }

        private void button28_Click(object sender, EventArgs e)
        {   if (label1.Text.Length>1)
            {
            label1.Text = label1.Text.Substring(0, label1.Text.Length-1);
            }
        else
            {
                label1.Text = "0";
            }
            
        }
    }
    }


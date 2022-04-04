using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizPanda_Venansius_0706022110001
{
    public partial class Form1 : Form
    {
        char[] temp = new char[] {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
        public Form1()
        {
            InitializeComponent();
        }

        private void tbinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbdari_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbmenjadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnkonv_Click(object sender, EventArgs e)
        {
            labelhasil.Text = "";
            string hsl = "";
            char[] temp7 = tbinput.Text.ToCharArray();

            char[] temp1 = tbdari.Text.ToCharArray();
            char temp2 = temp1[0];
            char[] temp3 = tbmenjadi.Text.ToCharArray();
            char temp4 = temp3[0];
            int selisih = temp4-temp2;

            tbinput.Text.ToCharArray();
            for (int i = 0; i < tbinput.TextLength; i++)
            {
                for (int j = 0; j < temp.Length; j++)
                {
                    if (tbinput.Text[i] == temp[j])
                    {
                        if (j+selisih >25)
                        {
                            hsl = hsl + temp[j + selisih-26];
                        }
                        else if (j+selisih <0)
                        {
                            hsl = hsl + temp[j + selisih+26];
                        }
                        else
                        {
                            hsl = hsl + temp[j + selisih];
                        }
                    }
                }
            }
            labelhasil.Text = hsl.ToUpper();
        }

        private void labelhasil_Click(object sender, EventArgs e)
        {

        }


    }
}

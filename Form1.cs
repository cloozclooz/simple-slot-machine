using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slots
{
    public partial class Form1 : Form
    {
        private bool autoSpin = false;

        public Form1()
        {
            InitializeComponent();
        }

        public void pelimekaniikka()
        {
            Random randomizer = new Random();
            int ekanumero;
            int tokanumero;
            int kolmasnumero;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;



            ekanumero = randomizer.Next(5);
            tokanumero = randomizer.Next(5);
            kolmasnumero = randomizer.Next(5);
            label1.SendToBack();
            label2.SendToBack();
            label3.SendToBack();
            this.Refresh();

            // Lohikäärme hedelmä eli numero 0
            if (ekanumero == 0)
            {
                pictureBox14.Visible = true;
            }
            else
            {
                pictureBox14.Visible = false;
            }

            if (tokanumero == 0)
            {
                pictureBox15.Visible = true;
            }
            else
            {
                pictureBox15.Visible = false;
            }

            if (kolmasnumero == 0)
            {
                pictureBox16.Visible = true;
            }
            else
            {
                pictureBox16.Visible = false;
            }

            // Apple icon
            if (ekanumero == 1)
            {
                pictureBox5.Visible = true;
            }
            else
            {
                pictureBox5.Visible = false;
            }
            if (tokanumero == 1)
            {
                pictureBox6.Visible = true;
            }
            else
            {
                pictureBox6.Visible = false;
            }

            if (kolmasnumero == 1)
            {
                pictureBox7.Visible = true;
            }
            else
            {
                pictureBox7.Visible = false;
            }

            // Banana icon
            if (ekanumero == 2)
            {
                pictureBox8.Visible = true;
            }
            else
            {
                pictureBox8.Visible = false;
            }
            if (tokanumero == 2)
            {
                pictureBox9.Visible = true;
            }
            else
            {
                pictureBox9.Visible = false;
            }
            if (kolmasnumero == 2)
            {
                pictureBox10.Visible = true;
            }
            else
            {
                pictureBox10.Visible = false;
            }


            // 7 Icon = number 3
            if (ekanumero == 3)
            {
                pictureBox2.Visible = true;
            }
            else
            {
                pictureBox2.Visible = false;
            }
            if (tokanumero == 3)
            {
                pictureBox3.Visible = true;
            }
            else
            {
                pictureBox3.Visible = false;
            }
            if (kolmasnumero == 3)
            {
                pictureBox4.Visible = true;
            }
            else
            {
                pictureBox4.Visible = false;
            }

            // Orange icon
            if (ekanumero == 4)
            {
                pictureBox11.Visible = true;
            }
            else
            {
                pictureBox11.Visible = false;
            }

            if (tokanumero == 4)
            {
                pictureBox12.Visible = true;
            }
            else
            {
                pictureBox12.Visible = false;
            }
            if (kolmasnumero == 4)
            {
                pictureBox13.Visible = true;
            }
            else
            {
                pictureBox13.Visible = false;
            }

            // Grapefruit icon
            if (ekanumero == 5)
            {
                pictureBox17.Visible = true;
            }
            else
            {
                pictureBox17.Visible = false;
            }

            if (tokanumero == 5)
            {
                pictureBox18.Visible = true;
            }
            else
            {
                pictureBox18.Visible = false;
            }

            if (kolmasnumero == 5)
            {
                pictureBox19.Visible = true;
            }
            else
            {
                pictureBox19.Visible = false;
            }
            label1.SendToBack();

            bool voitto = false;

            if ((ekanumero == 3 && tokanumero == 3) || (tokanumero == 3 && kolmasnumero == 3) || (ekanumero == 3 && kolmasnumero == 3))


            {
                voitto = true;
            }
            if (voitto)
            {
                //MessageBox.Show("Onneksi olkoon! VOITIT");
                autoSpin = false;
                pictureBox1.Visible = true;
            }
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            btnSpin.Enabled = true;
            pelimekaniikka();

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void btnAuto_Click(object sender, EventArgs e)
        {
            btnAuto.Enabled = false;
            autoSpin = true;
            pictureBox1.Visible = false;
            {
                while (autoSpin)
                {
                    btnSpin_Click(sender, e);
                    {
                        Thread.Sleep(250);
                        Application.DoEvents();
                    }
                    Thread.Sleep(200);
                    Application.DoEvents();
                }
                btnAuto.Enabled = true;
            }
        }

        private void btnAutoPois_Click(object sender, EventArgs e)
        {
            autoSpin = false;
            btnAuto.Enabled = true;
            //btnAuto.Enabled = true;


        }
        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}




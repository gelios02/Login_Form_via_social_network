using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        
        Form2 frm2 = new Form2();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frm2.Show();

            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.picfb, "Login with Facebook");
            toolTip1.SetToolTip(this.pictw, "Login with Twitter");
            toolTip1.SetToolTip(this.picgp, "Login with Google");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '●';
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            pic1.BackgroundImage = Properties.Resources.user2;
            panel1.BackColor = Color.FromArgb(3, 155, 229);
            textBox1.ForeColor = Color.FromArgb(3, 155, 229);

            picpass.BackgroundImage = Properties.Resources.padlock_unlock;
            panel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            picemail.BackgroundImage = Properties.Resources.email;
            panel3.BackColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.PasswordChar = '●';
            picpass.BackgroundImage = Properties.Resources.padlock_unlock1;
            panel2.ForeColor = Color.FromArgb(3, 155, 229);
            textBox2.ForeColor = Color.FromArgb(3, 155, 229);

            pic1.BackgroundImage = Properties.Resources.user;
            panel1.BackColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.WhiteSmoke;

            picemail.BackgroundImage = Properties.Resources.email;
            panel3.BackColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            picemail.BackgroundImage = Properties.Resources.email1;
            panel3.BackColor = Color.FromArgb(3, 155, 229);
            textBox3.ForeColor =  Color.FromArgb(3, 155, 229);

            pic1.BackgroundImage = Properties.Resources.user;
            panel1.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            picpass.BackgroundImage = Properties.Resources.padlock_unlock;
            panel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;
        }

        private void picfb_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

       

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            frm2.Left += 10;
            if (frm2.Left >= 830)
            {
                timer1.Stop();
                this.TopMost = false;
                frm2.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            frm2.Left -= 5;
            if (frm2.Left <= 620)
            {
                timer2.Stop();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
} 

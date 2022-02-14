using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuchi_cuchi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panel8.Hide();
            panel9.Hide();
            panel10.Hide();
            panel11.Hide();
            panel12.Hide();
            panel13.Hide();
            panel14.Hide();
            panel15.Hide();
            panel16.Hide();
            panel17.Hide();
            panel18.Hide();
            panel19.Hide();
            panel20.Hide();
            panel21.Hide();
            panel22.Hide();
            panel23.Hide();
            panel24.Hide();
            panel25.Hide();
            panel26.Hide();
            panel27.Hide();
            panel28.Hide();
            panel29.Hide();
            panel30.Hide();
            panel31.Hide();
            panel32.Hide();
            panel33.Hide();
            panel34.Hide();
            panel35.Hide();
            panel36.Hide();
            panel37.Hide();
            panel38.Hide();

        }

        public void MoverBoton()
        {
            Random r = new Random();
            int x = r.Next(0, this.Width - button3.Width);
            int y = r.Next(0, this.Height - button3.Height);
            button3.Location = new Point(x, y);
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            MoverBoton();
            if (button3.Location == button1.Location || button3.Location == button2.Location)
            {
                MoverBoton();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel5.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel6.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel7.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel8.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel9.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel10.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel11.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panel12.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            panel13.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            panel14.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            panel15.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            panel16.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            panel17.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            panel18.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            panel19.Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            panel20.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            panel21.Show();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            panel22.Show();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            panel23.Show();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            panel24.Show();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            panel25.Show();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            panel26.Show();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            panel27.Show();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            panel28.Show();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            panel29.Show();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            panel30.Show();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            panel31.Show();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            panel32.Show();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            panel33.Show();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            panel34.Show();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            panel35.Show();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            panel36.Show();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            panel37.Show();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            panel38.Show();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
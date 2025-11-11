using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MENU
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static int picnum = 0;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            picnum = 1;
            form3.ShowDialog();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            picnum = 2;
            form3.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            picnum = 3;
            form3.ShowDialog();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void refresh()
        {
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "以選取" + Form3.buynum[0] + "隻";
            label2.Text = "以選取" + Form3.buynum[1] + "隻";
            label3.Text = "以選取" + Form3.buynum[2] + "隻";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Form2_Load(sender, e);
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            label1.Text = "以選取" + Form3.buynum[0] + "隻";
            label2.Text = "以選取" + Form3.buynum[1] + "隻";
            label3.Text = "以選取" + Form3.buynum[2] + "隻";
        }
    }
}

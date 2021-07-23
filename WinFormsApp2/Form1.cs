using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            GererUnClient unClient = new GererUnClient();
            unClient.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void client(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }

        private void compte(object sender, EventArgs e)
        {
            Compte compte = new Compte();
                compte.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            GererUnCompte gerer = new GererUnCompte();
            gerer.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

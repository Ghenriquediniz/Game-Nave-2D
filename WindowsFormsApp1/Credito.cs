using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Credito : Form
    {
        public Credito()
        {
            InitializeComponent();
            this.ControlBox = true;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Aplicação feita por Gu.";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCK9KJuaokAKY-Qm4YAPvcQw");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Ghenriquediniz");
        }

        private void Credito_Load(object sender, EventArgs e)
        {

        }
    }
}

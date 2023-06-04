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
    public partial class Alerta : Form
    {
        public Alerta()
        {
            InitializeComponent();

        }

        private void Alerta_Load(object sender, EventArgs e)
        {
            lbl_Alerta.Parent = picture_Alerta;
            lbl_Alerta.BackColor = Color.Transparent;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            
        }

        private void btn_Alerta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_Alerta_Click(object sender, EventArgs e)
        {
            lbl_Alerta.Parent = picture_Alerta;
            lbl_Alerta.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void picture_Alerta_Click(object sender, EventArgs e)
        {

        }
    }
}

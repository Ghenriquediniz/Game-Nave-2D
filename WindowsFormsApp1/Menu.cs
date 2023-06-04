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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lbl_Resume.BackColor = Color.Transparent;
            lbl_Resume.Parent = picture_Menu;
            lbl_Creditos.BackColor = Color.Transparent;
            lbl_Creditos.Parent = picture_Menu;
            lbl_Resetar.BackColor = Color.Transparent;
            lbl_Resetar.Parent = picture_Menu;
            lbl_Sair.BackColor = Color.Transparent;
            lbl_Sair.Parent = picture_Menu;
        }

        private void lbl_Resume_Click(object sender, EventArgs e)
        {
            this.Close();
            lbl_Resume.Cursor = Cursors.Hand;
        }

        private void picture_Menu_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Resetar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void lbl_Creditos_Click(object sender, EventArgs e)
        {
            Credito credito = new Credito();
            credito.StartPosition = FormStartPosition.CenterParent;
            credito.ShowDialog(this);
        }

        private void lbl_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

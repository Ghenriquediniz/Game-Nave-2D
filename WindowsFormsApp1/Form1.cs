using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class form_game : Form

    {
        
        int pontos = 0;
        private int pontosPorSegundo = 0;
        private bool botaoPowerComprado = false;
        private int pontosPower = 0;
        private bool botaoAuto = false;
        private int valorClick = 1;
        private int contadorPower = 0;
        private bool mostraContadorPower = false;
        private int contadorAuto = 0;
        private bool mostraContadorAuto = false;
        

        public form_game()
        {
            InitializeComponent();
            picture_nave.BackColor = Color.Transparent;
            lbl_Click_Power.BackColor = Color.Transparent;
            lbl_Click_Power.Visible = false;
            lbl_Click_Auto.BackColor = Color.Transparent;
            lbl_Click_Auto.Visible = false;
        }

        private void picture_nave_Click(object sender, EventArgs e)
        {

        }

        private void lbl_pontos_Click(object sender, EventArgs e)
        {

        }

        private void btn_click_Click(object sender, EventArgs e)
        {
            if (botaoPowerComprado)
            {
                pontos += pontosPower;
            }
            else
            {
                pontos += valorClick;
            }

            lbl_pontos.Text = $"Pontos: {pontos}";
            
        }

        /* Autoclick */
        private void btn_autoclick_Click(object sender, EventArgs e)
        {
            if (pontos >= 30)
            {
                if (!botaoAuto)
                {
                    pontosPorSegundo = 1;
                    TimerAutoClick.Interval = 2000;
                    TimerAutoClick.Start();
                    botaoAuto = true;

                    pontos -= 30;
                    lbl_pontos.Text = $"Pontos: {pontos}";

                    contadorAuto++;
                }
                else
                {
                    pontosPorSegundo++;
                    pontos -= 30;
                    lbl_pontos.Text = $"Pontos: {pontos}";

                    contadorAuto++;
                }
                if (!mostraContadorAuto)
                {
                    lbl_Click_Auto.Visible = true;
                    mostraContadorAuto = true; 
                }
            }
            else
            {
                Alerta alerta = new Alerta();
                alerta.StartPosition = FormStartPosition.CenterParent;
                alerta.ShowDialog(this);
            }

            lbl_Click_Auto.Text = $"{contadorAuto}x";
        }

        private void btn_power_Click(object sender, EventArgs e)
        {
            if (pontos >= 50)
            {
                if (!botaoPowerComprado)
                {
                    pontosPower = 2;
                    botaoPowerComprado = true;
                    pontos -= 50;
                    lbl_pontos.Text = $"Pontos: {pontos}";
                    contadorPower++;
                }
                else
                {
                    pontosPower += 2;
                    pontos -= 50;
                    lbl_pontos.Text = $"Pontos: {pontos}";
                    contadorPower++;
                }
                if (!mostraContadorPower)
                {
                    mostraContadorPower = true;
                    lbl_Click_Power.Visible = true;
                }
            }
            else
            {
                Alerta alerta = new Alerta();
                alerta.StartPosition = FormStartPosition.CenterParent;
                alerta.ShowDialog(this);
            }

            lbl_Click_Power.Text = $"{contadorPower}x";

        }

        private void TimerAutoClick_Tick(object sender, EventArgs e)
        {
            pontos += pontosPorSegundo;
            lbl_pontos.Text = $"Pontos: {pontos}";
        }

        private void lbl_Click_Vl_Click(object sender, EventArgs e)
        {
            lbl_Click_Power.Visible = false;
        }

        private void lbl_Click_Auto_Click(object sender, EventArgs e)
        {
            lbl_Click_Auto.Visible = false;
        }
        private void form_game_Load(object sender, EventArgs e)
        {
            
        }

        private void picture_Conf_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.StartPosition = FormStartPosition.CenterParent;
            menu.ShowDialog(this);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void Form_game_MouseDown(object sender, MouseEventArgs e)
        {

        }


      
        private void form_game_MouseDown(object sender, MouseEventArgs e)
        {
           
        }


    }

}

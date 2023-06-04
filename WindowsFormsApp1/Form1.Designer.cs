namespace WindowsFormsApp1
{
    partial class form_game
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_game));
            this.picture_nave = new System.Windows.Forms.PictureBox();
            this.btn_click = new System.Windows.Forms.Button();
            this.lbl_pontos = new System.Windows.Forms.Label();
            this.btn_autoclick = new System.Windows.Forms.Button();
            this.TimerAutoClick = new System.Windows.Forms.Timer(this.components);
            this.btn_power = new System.Windows.Forms.Button();
            this.lbl_Click_Power = new System.Windows.Forms.Label();
            this.lbl_Click_Auto = new System.Windows.Forms.Label();
            this.picture_Conf = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_nave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Conf)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_nave
            // 
            this.picture_nave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picture_nave.Image = ((System.Drawing.Image)(resources.GetObject("picture_nave.Image")));
            this.picture_nave.Location = new System.Drawing.Point(116, 177);
            this.picture_nave.Name = "picture_nave";
            this.picture_nave.Size = new System.Drawing.Size(224, 371);
            this.picture_nave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_nave.TabIndex = 0;
            this.picture_nave.TabStop = false;
            this.picture_nave.Click += new System.EventHandler(this.picture_nave_Click);
            // 
            // btn_click
            // 
            this.btn_click.BackColor = System.Drawing.Color.Cyan;
            this.btn_click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_click.CausesValidation = false;
            this.btn_click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_click.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_click.Location = new System.Drawing.Point(116, 583);
            this.btn_click.Margin = new System.Windows.Forms.Padding(0);
            this.btn_click.Name = "btn_click";
            this.btn_click.Size = new System.Drawing.Size(224, 68);
            this.btn_click.TabIndex = 1;
            this.btn_click.Text = "Click";
            this.btn_click.UseVisualStyleBackColor = false;
            this.btn_click.Click += new System.EventHandler(this.btn_click_Click);
            // 
            // lbl_pontos
            // 
            this.lbl_pontos.AutoSize = true;
            this.lbl_pontos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pontos.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pontos.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_pontos.Location = new System.Drawing.Point(149, 28);
            this.lbl_pontos.Name = "lbl_pontos";
            this.lbl_pontos.Size = new System.Drawing.Size(159, 33);
            this.lbl_pontos.TabIndex = 2;
            this.lbl_pontos.Text = "Pontos: 0";
            this.lbl_pontos.Click += new System.EventHandler(this.lbl_pontos_Click);
            // 
            // btn_autoclick
            // 
            this.btn_autoclick.BackColor = System.Drawing.Color.Cyan;
            this.btn_autoclick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_autoclick.CausesValidation = false;
            this.btn_autoclick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_autoclick.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_autoclick.Location = new System.Drawing.Point(21, 691);
            this.btn_autoclick.Margin = new System.Windows.Forms.Padding(0);
            this.btn_autoclick.Name = "btn_autoclick";
            this.btn_autoclick.Size = new System.Drawing.Size(206, 75);
            this.btn_autoclick.TabIndex = 3;
            this.btn_autoclick.Text = "Auto  Click  Custo 30 Pontos";
            this.btn_autoclick.UseCompatibleTextRendering = true;
            this.btn_autoclick.UseVisualStyleBackColor = false;
            this.btn_autoclick.Click += new System.EventHandler(this.btn_autoclick_Click);
            // 
            // TimerAutoClick
            // 
            this.TimerAutoClick.Tick += new System.EventHandler(this.TimerAutoClick_Tick);
            // 
            // btn_power
            // 
            this.btn_power.BackColor = System.Drawing.Color.Cyan;
            this.btn_power.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_power.CausesValidation = false;
            this.btn_power.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_power.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_power.Location = new System.Drawing.Point(243, 691);
            this.btn_power.Margin = new System.Windows.Forms.Padding(0);
            this.btn_power.Name = "btn_power";
            this.btn_power.Size = new System.Drawing.Size(216, 75);
            this.btn_power.TabIndex = 4;
            this.btn_power.Text = "Power Click Custo 50 Pontos";
            this.btn_power.UseVisualStyleBackColor = false;
            this.btn_power.Click += new System.EventHandler(this.btn_power_Click);
            // 
            // lbl_Click_Power
            // 
            this.lbl_Click_Power.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Click_Power.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Click_Power.Location = new System.Drawing.Point(381, 660);
            this.lbl_Click_Power.Name = "lbl_Click_Power";
            this.lbl_Click_Power.Size = new System.Drawing.Size(78, 31);
            this.lbl_Click_Power.TabIndex = 7;
            this.lbl_Click_Power.Text = "100x";
            this.lbl_Click_Power.Click += new System.EventHandler(this.lbl_Click_Vl_Click);
            // 
            // lbl_Click_Auto
            // 
            this.lbl_Click_Auto.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Click_Auto.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Click_Auto.Location = new System.Drawing.Point(149, 660);
            this.lbl_Click_Auto.Name = "lbl_Click_Auto";
            this.lbl_Click_Auto.Size = new System.Drawing.Size(78, 31);
            this.lbl_Click_Auto.TabIndex = 8;
            this.lbl_Click_Auto.Text = "100x";
            this.lbl_Click_Auto.Click += new System.EventHandler(this.lbl_Click_Auto_Click);
            // 
            // picture_Conf
            // 
            this.picture_Conf.BackColor = System.Drawing.Color.Transparent;
            this.picture_Conf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_Conf.BackgroundImage")));
            this.picture_Conf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_Conf.Location = new System.Drawing.Point(411, 18);
            this.picture_Conf.Name = "picture_Conf";
            this.picture_Conf.Size = new System.Drawing.Size(70, 43);
            this.picture_Conf.TabIndex = 9;
            this.picture_Conf.TabStop = false;
            this.picture_Conf.Click += new System.EventHandler(this.picture_Conf_Click);
            // 
            // form_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(493, 800);
            this.Controls.Add(this.picture_Conf);
            this.Controls.Add(this.lbl_Click_Auto);
            this.Controls.Add(this.lbl_Click_Power);
            this.Controls.Add(this.btn_power);
            this.Controls.Add(this.btn_autoclick);
            this.Controls.Add(this.lbl_pontos);
            this.Controls.Add(this.btn_click);
            this.Controls.Add(this.picture_nave);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form_game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Nave";
            this.Load += new System.EventHandler(this.form_game_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_game_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picture_nave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Conf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picture_nave;
        public System.Windows.Forms.Button btn_click;
        private System.Windows.Forms.Label lbl_pontos;
        public System.Windows.Forms.Button btn_autoclick;
        private System.Windows.Forms.Timer TimerAutoClick;
        public System.Windows.Forms.Button btn_power;
        private System.Windows.Forms.Label lbl_Click_Power;
        private System.Windows.Forms.Label lbl_Click_Auto;
        private System.Windows.Forms.PictureBox picture_Conf;
    }
}


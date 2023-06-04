namespace WindowsFormsApp1
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.picture_Menu = new System.Windows.Forms.PictureBox();
            this.lbl_Resume = new System.Windows.Forms.Label();
            this.lbl_Resetar = new System.Windows.Forms.Label();
            this.lbl_Creditos = new System.Windows.Forms.Label();
            this.lbl_Sair = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Menu)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_Menu
            // 
            this.picture_Menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_Menu.BackgroundImage")));
            this.picture_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_Menu.Location = new System.Drawing.Point(-2, -2);
            this.picture_Menu.Name = "picture_Menu";
            this.picture_Menu.Size = new System.Drawing.Size(497, 816);
            this.picture_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picture_Menu.TabIndex = 0;
            this.picture_Menu.TabStop = false;
            this.picture_Menu.WaitOnLoad = true;
            this.picture_Menu.Click += new System.EventHandler(this.picture_Menu_Click);
            // 
            // lbl_Resume
            // 
            this.lbl_Resume.AutoSize = true;
            this.lbl_Resume.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Resume.Font = new System.Drawing.Font("Unispace", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resume.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Resume.Location = new System.Drawing.Point(131, 181);
            this.lbl_Resume.Name = "lbl_Resume";
            this.lbl_Resume.Size = new System.Drawing.Size(257, 58);
            this.lbl_Resume.TabIndex = 1;
            this.lbl_Resume.Text = "Retornar";
            this.lbl_Resume.Click += new System.EventHandler(this.lbl_Resume_Click);
            // 
            // lbl_Resetar
            // 
            this.lbl_Resetar.AutoSize = true;
            this.lbl_Resetar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Resetar.Font = new System.Drawing.Font("Unispace", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resetar.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Resetar.Location = new System.Drawing.Point(146, 281);
            this.lbl_Resetar.Name = "lbl_Resetar";
            this.lbl_Resetar.Size = new System.Drawing.Size(228, 58);
            this.lbl_Resetar.TabIndex = 2;
            this.lbl_Resetar.Text = "Resetar";
            this.lbl_Resetar.Click += new System.EventHandler(this.lbl_Resetar_Click);
            // 
            // lbl_Creditos
            // 
            this.lbl_Creditos.AutoSize = true;
            this.lbl_Creditos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Creditos.Font = new System.Drawing.Font("Unispace", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Creditos.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Creditos.Location = new System.Drawing.Point(131, 376);
            this.lbl_Creditos.Name = "lbl_Creditos";
            this.lbl_Creditos.Size = new System.Drawing.Size(257, 58);
            this.lbl_Creditos.TabIndex = 3;
            this.lbl_Creditos.Text = "Créditos";
            this.lbl_Creditos.Click += new System.EventHandler(this.lbl_Creditos_Click);
            // 
            // lbl_Sair
            // 
            this.lbl_Sair.AutoSize = true;
            this.lbl_Sair.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Sair.Font = new System.Drawing.Font("Unispace", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sair.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Sair.Location = new System.Drawing.Point(183, 478);
            this.lbl_Sair.Name = "lbl_Sair";
            this.lbl_Sair.Size = new System.Drawing.Size(141, 58);
            this.lbl_Sair.TabIndex = 4;
            this.lbl_Sair.Text = "Sair";
            this.lbl_Sair.Click += new System.EventHandler(this.lbl_Sair_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(493, 791);
            this.Controls.Add(this.lbl_Sair);
            this.Controls.Add(this.lbl_Creditos);
            this.Controls.Add(this.lbl_Resetar);
            this.Controls.Add(this.lbl_Resume);
            this.Controls.Add(this.picture_Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_Menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_Menu;
        private System.Windows.Forms.Label lbl_Resume;
        private System.Windows.Forms.Label lbl_Resetar;
        private System.Windows.Forms.Label lbl_Creditos;
        private System.Windows.Forms.Label lbl_Sair;
    }
}
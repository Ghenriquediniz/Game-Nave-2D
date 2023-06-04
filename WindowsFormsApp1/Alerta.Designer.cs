namespace WindowsFormsApp1
{
    partial class Alerta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alerta));
            this.lbl_Alerta = new System.Windows.Forms.Label();
            this.btn_Alerta = new System.Windows.Forms.Button();
            this.picture_Alerta = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Alerta)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Alerta
            // 
            this.lbl_Alerta.AutoSize = true;
            this.lbl_Alerta.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Alerta.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Alerta.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_Alerta.Location = new System.Drawing.Point(36, 29);
            this.lbl_Alerta.Name = "lbl_Alerta";
            this.lbl_Alerta.Size = new System.Drawing.Size(196, 42);
            this.lbl_Alerta.TabIndex = 1;
            this.lbl_Alerta.Text = "Sem Saldo!";
            this.lbl_Alerta.Click += new System.EventHandler(this.lbl_Alerta_Click);
            // 
            // btn_Alerta
            // 
            this.btn_Alerta.BackColor = System.Drawing.Color.Cyan;
            this.btn_Alerta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Alerta.CausesValidation = false;
            this.btn_Alerta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alerta.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alerta.Location = new System.Drawing.Point(80, 96);
            this.btn_Alerta.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Alerta.Name = "btn_Alerta";
            this.btn_Alerta.Size = new System.Drawing.Size(110, 47);
            this.btn_Alerta.TabIndex = 2;
            this.btn_Alerta.Text = "OK";
            this.btn_Alerta.UseVisualStyleBackColor = false;
            this.btn_Alerta.Click += new System.EventHandler(this.btn_Alerta_Click);
            // 
            // picture_Alerta
            // 
            this.picture_Alerta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picture_Alerta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_Alerta.BackgroundImage")));
            this.picture_Alerta.Location = new System.Drawing.Point(-4, -4);
            this.picture_Alerta.Name = "picture_Alerta";
            this.picture_Alerta.Size = new System.Drawing.Size(269, 169);
            this.picture_Alerta.TabIndex = 3;
            this.picture_Alerta.TabStop = false;
            this.picture_Alerta.Click += new System.EventHandler(this.picture_Alerta_Click);
            // 
            // Alerta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(261, 163);
            this.Controls.Add(this.lbl_Alerta);
            this.Controls.Add(this.btn_Alerta);
            this.Controls.Add(this.picture_Alerta);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alerta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alerta";
            this.Load += new System.EventHandler(this.Alerta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_Alerta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btn_Alerta;
        private System.Windows.Forms.PictureBox picture_Alerta;
        private System.Windows.Forms.Label lbl_Alerta;
    }
}
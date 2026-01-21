namespace PryPrueba2
{
    partial class Ingresar
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
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.lblNoTienesCuenta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCrearCuenta = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.chkRecordar = new System.Windows.Forms.CheckBox();
            this.lblOlvidasteContra = new System.Windows.Forms.LinkLabel();
            this.pnlIngresar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCuenta.Location = new System.Drawing.Point(805, 26);
            this.btnCrearCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(86, 28);
            this.btnCrearCuenta.TabIndex = 28;
            this.btnCrearCuenta.Text = "Crear cuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = true;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // lblNoTienesCuenta
            // 
            this.lblNoTienesCuenta.AutoSize = true;
            this.lblNoTienesCuenta.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoTienesCuenta.Location = new System.Drawing.Point(543, 30);
            this.lblNoTienesCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoTienesCuenta.Name = "lblNoTienesCuenta";
            this.lblNoTienesCuenta.Size = new System.Drawing.Size(263, 21);
            this.lblNoTienesCuenta.TabIndex = 27;
            this.lblNoTienesCuenta.Text = "¿Todavía no tienes una cuenta?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 43);
            this.label2.TabIndex = 26;
            this.label2.Text = "DigitalFarma";
            // 
            // lblCrearCuenta
            // 
            this.lblCrearCuenta.AutoSize = true;
            this.lblCrearCuenta.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearCuenta.Location = new System.Drawing.Point(272, 178);
            this.lblCrearCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCrearCuenta.Name = "lblCrearCuenta";
            this.lblCrearCuenta.Size = new System.Drawing.Size(405, 47);
            this.lblCrearCuenta.TabIndex = 25;
            this.lblCrearCuenta.Text = "Ingresa a tu cuenta";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Teal;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIngresar.Location = new System.Drawing.Point(229, 397);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(497, 44);
            this.btnIngresar.TabIndex = 22;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMail.Location = new System.Drawing.Point(230, 263);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(496, 43);
            this.txtMail.TabIndex = 21;
            this.txtMail.Text = "Mail";
            // 
            // txtContra
            // 
            this.txtContra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtContra.Location = new System.Drawing.Point(230, 312);
            this.txtContra.Margin = new System.Windows.Forms.Padding(4);
            this.txtContra.Multiline = true;
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(496, 43);
            this.txtContra.TabIndex = 20;
            this.txtContra.Text = "Contraseña";
            // 
            // pctLogo
            // 
            this.pctLogo.BackgroundImage = global::PryPrueba2.Properties.Resources.LOGO_DIGITALFARMA1;
            this.pctLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctLogo.Location = new System.Drawing.Point(13, 15);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(62, 68);
            this.pctLogo.TabIndex = 31;
            this.pctLogo.TabStop = false;
            // 
            // chkRecordar
            // 
            this.chkRecordar.AutoSize = true;
            this.chkRecordar.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRecordar.Location = new System.Drawing.Point(230, 369);
            this.chkRecordar.Name = "chkRecordar";
            this.chkRecordar.Size = new System.Drawing.Size(211, 25);
            this.chkRecordar.TabIndex = 32;
            this.chkRecordar.Text = "Recordar credenciales";
            this.chkRecordar.UseVisualStyleBackColor = true;
            // 
            // lblOlvidasteContra
            // 
            this.lblOlvidasteContra.AutoSize = true;
            this.lblOlvidasteContra.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOlvidasteContra.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblOlvidasteContra.Location = new System.Drawing.Point(508, 369);
            this.lblOlvidasteContra.Name = "lblOlvidasteContra";
            this.lblOlvidasteContra.Size = new System.Drawing.Size(218, 21);
            this.lblOlvidasteContra.TabIndex = 33;
            this.lblOlvidasteContra.TabStop = true;
            this.lblOlvidasteContra.Text = "¿Olvidaste tu contraseña?";
            // 
            // pnlIngresar
            // 
            this.pnlIngresar.BackColor = System.Drawing.Color.Teal;
            this.pnlIngresar.Location = new System.Drawing.Point(899, 1);
            this.pnlIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlIngresar.Name = "pnlIngresar";
            this.pnlIngresar.Size = new System.Drawing.Size(287, 640);
            this.pnlIngresar.TabIndex = 34;
            // 
            // Ingresar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 639);
            this.Controls.Add(this.pnlIngresar);
            this.Controls.Add(this.lblOlvidasteContra);
            this.Controls.Add(this.chkRecordar);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.btnCrearCuenta);
            this.Controls.Add(this.lblNoTienesCuenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCrearCuenta);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtContra);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ingresar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar";
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.Label lblNoTienesCuenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCrearCuenta;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.CheckBox chkRecordar;
        private System.Windows.Forms.LinkLabel lblOlvidasteContra;
        private System.Windows.Forms.Panel pnlIngresar;
    }
}
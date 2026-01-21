namespace PryPrueba2
{
    partial class Login
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
            this.pnlCrearCuenta = new System.Windows.Forms.Panel();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnSig = new System.Windows.Forms.Button();
            this.LnkPolitica = new System.Windows.Forms.LinkLabel();
            this.lblPolitica = new System.Windows.Forms.Label();
            this.lblCrearCuenta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblYaTienesCuenta = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.progressBarContra = new System.Windows.Forms.ProgressBar();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnVerContra = new System.Windows.Forms.Button();
            this.pnlCrearCuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCrearCuenta
            // 
            this.pnlCrearCuenta.BackColor = System.Drawing.Color.Teal;
            this.pnlCrearCuenta.Controls.Add(this.lblBienvenido);
            this.pnlCrearCuenta.Controls.Add(this.pictureBox1);
            this.pnlCrearCuenta.Location = new System.Drawing.Point(912, 0);
            this.pnlCrearCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCrearCuenta.Name = "pnlCrearCuenta";
            this.pnlCrearCuenta.Size = new System.Drawing.Size(287, 640);
            this.pnlCrearCuenta.TabIndex = 1;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBienvenido.Location = new System.Drawing.Point(56, 375);
            this.lblBienvenido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(201, 68);
            this.lblBienvenido.TabIndex = 18;
            this.lblBienvenido.Text = "Bienvenido a \r\nDigitalFarma";
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PryPrueba2.Properties.Resources.LOGO_DIGITALFARMA1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(62, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 162);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNombre.Location = new System.Drawing.Point(242, 245);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(244, 41);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtApellido.Location = new System.Drawing.Point(494, 245);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(244, 41);
            this.txtApellido.TabIndex = 5;
            this.txtApellido.Text = "Apellido";
            // 
            // txtContra
            // 
            this.txtContra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtContra.Location = new System.Drawing.Point(242, 343);
            this.txtContra.Margin = new System.Windows.Forms.Padding(4);
            this.txtContra.Multiline = true;
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(496, 41);
            this.txtContra.TabIndex = 6;
            this.txtContra.Text = "Contraseña";
            this.txtContra.TextChanged += new System.EventHandler(this.txtContra_TextChanged);
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMail.Location = new System.Drawing.Point(242, 294);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(496, 41);
            this.txtMail.TabIndex = 7;
            this.txtMail.Text = "Mail";
            // 
            // btnSig
            // 
            this.btnSig.BackColor = System.Drawing.Color.Teal;
            this.btnSig.FlatAppearance.BorderSize = 0;
            this.btnSig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSig.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSig.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSig.Location = new System.Drawing.Point(242, 439);
            this.btnSig.Margin = new System.Windows.Forms.Padding(4);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(497, 42);
            this.btnSig.TabIndex = 8;
            this.btnSig.Text = "SIGUIENTE";
            this.btnSig.UseVisualStyleBackColor = false;
            this.btnSig.Click += new System.EventHandler(this.btnSig_Click);
            // 
            // LnkPolitica
            // 
            this.LnkPolitica.AutoSize = true;
            this.LnkPolitica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkPolitica.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LnkPolitica.Location = new System.Drawing.Point(348, 522);
            this.LnkPolitica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LnkPolitica.Name = "LnkPolitica";
            this.LnkPolitica.Size = new System.Drawing.Size(0, 20);
            this.LnkPolitica.TabIndex = 9;
            // 
            // lblPolitica
            // 
            this.lblPolitica.AutoSize = true;
            this.lblPolitica.Location = new System.Drawing.Point(221, 501);
            this.lblPolitica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPolitica.Name = "lblPolitica";
            this.lblPolitica.Size = new System.Drawing.Size(0, 21);
            this.lblPolitica.TabIndex = 10;
            // 
            // lblCrearCuenta
            // 
            this.lblCrearCuenta.AutoSize = true;
            this.lblCrearCuenta.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearCuenta.Location = new System.Drawing.Point(301, 178);
            this.lblCrearCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCrearCuenta.Name = "lblCrearCuenta";
            this.lblCrearCuenta.Size = new System.Drawing.Size(371, 47);
            this.lblCrearCuenta.TabIndex = 11;
            this.lblCrearCuenta.Text = "Crear una cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 43);
            this.label2.TabIndex = 12;
            this.label2.Text = "DigitalFarma";
            // 
            // lblYaTienesCuenta
            // 
            this.lblYaTienesCuenta.AutoSize = true;
            this.lblYaTienesCuenta.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYaTienesCuenta.Location = new System.Drawing.Point(619, 24);
            this.lblYaTienesCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYaTienesCuenta.Name = "lblYaTienesCuenta";
            this.lblYaTienesCuenta.Size = new System.Drawing.Size(197, 21);
            this.lblYaTienesCuenta.TabIndex = 13;
            this.lblYaTienesCuenta.Text = "¿Ya tienes una cuenta?";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(818, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pctLogo
            // 
            this.pctLogo.BackgroundImage = global::PryPrueba2.Properties.Resources.LOGO_DIGITALFARMA1;
            this.pctLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctLogo.Location = new System.Drawing.Point(12, 12);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(62, 66);
            this.pctLogo.TabIndex = 17;
            this.pctLogo.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(55, 46);
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(263, 498);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(445, 44);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Al crear una significa que esta de acuerdo con nuestra Politica de Privacidad y T" +
    "érminos de Servicio.";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // progressBarContra
            // 
            this.progressBarContra.Location = new System.Drawing.Point(242, 391);
            this.progressBarContra.Name = "progressBarContra";
            this.progressBarContra.Size = new System.Drawing.Size(490, 10);
            this.progressBarContra.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarContra.TabIndex = 19;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(566, 404);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(173, 21);
            this.lblEstado.TabIndex = 20;
            this.lblEstado.Text = "Contraseña insegura";
            // 
            // btnVerContra
            // 
            this.btnVerContra.BackColor = System.Drawing.Color.RosyBrown;
            this.btnVerContra.Location = new System.Drawing.Point(651, 342);
            this.btnVerContra.Name = "btnVerContra";
            this.btnVerContra.Size = new System.Drawing.Size(81, 36);
            this.btnVerContra.TabIndex = 21;
            this.btnVerContra.UseVisualStyleBackColor = false;
            this.btnVerContra.Click += new System.EventHandler(this.btnVerContra_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 637);
            this.Controls.Add(this.btnVerContra);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.progressBarContra);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblYaTienesCuenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCrearCuenta);
            this.Controls.Add(this.lblPolitica);
            this.Controls.Add(this.LnkPolitica);
            this.Controls.Add(this.btnSig);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.pnlCrearCuenta);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnlCrearCuenta.ResumeLayout(false);
            this.pnlCrearCuenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCrearCuenta;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnSig;
        private System.Windows.Forms.LinkLabel LnkPolitica;
        private System.Windows.Forms.Label lblPolitica;
        private System.Windows.Forms.Label lblCrearCuenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblYaTienesCuenta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ProgressBar progressBarContra;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnVerContra;
    }
}
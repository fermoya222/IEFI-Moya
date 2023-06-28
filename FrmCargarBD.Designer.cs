namespace pryMoyaIEFI
{
    partial class FrmCargarBD
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbIniciar = new System.Windows.Forms.GroupBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.cmbApellido = new System.Windows.Forms.ComboBox();
            this.cmbNombre = new System.Windows.Forms.ComboBox();
            this.mtxtPuntaje = new System.Windows.Forms.MaskedTextBox();
            this.mtxtIngreso = new System.Windows.Forms.MaskedTextBox();
            this.mtxtEdad = new System.Windows.Forms.MaskedTextBox();
            this.lblPaislogin = new System.Windows.Forms.Label();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.GroupBox();
            this.btnFemenino = new System.Windows.Forms.RadioButton();
            this.optMasculino = new System.Windows.Forms.RadioButton();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.cmbIniciar.SuspendLayout();
            this.cmbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.RosyBrown;
            this.lblTitulo.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(181, 47);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(99, 18);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "POLO CLUB";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // cmbIniciar
            // 
            this.cmbIniciar.Controls.Add(this.txtApellido);
            this.cmbIniciar.Controls.Add(this.txtNombre);
            this.cmbIniciar.Controls.Add(this.cmbPais);
            this.cmbIniciar.Controls.Add(this.cmbApellido);
            this.cmbIniciar.Controls.Add(this.cmbNombre);
            this.cmbIniciar.Controls.Add(this.mtxtPuntaje);
            this.cmbIniciar.Controls.Add(this.mtxtIngreso);
            this.cmbIniciar.Controls.Add(this.mtxtEdad);
            this.cmbIniciar.Controls.Add(this.lblPaislogin);
            this.cmbIniciar.Controls.Add(this.lblPuntaje);
            this.cmbIniciar.Controls.Add(this.lblIngreso);
            this.cmbIniciar.Controls.Add(this.cmbSexo);
            this.cmbIniciar.Controls.Add(this.lblEdad);
            this.cmbIniciar.Controls.Add(this.lblApellido);
            this.cmbIniciar.Controls.Add(this.lblNombre);
            this.cmbIniciar.Location = new System.Drawing.Point(58, 100);
            this.cmbIniciar.Name = "cmbIniciar";
            this.cmbIniciar.Size = new System.Drawing.Size(343, 382);
            this.cmbIniciar.TabIndex = 1;
            this.cmbIniciar.TabStop = false;
            this.cmbIniciar.Text = "Registrar";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(83, 73);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(96, 20);
            this.txtApellido.TabIndex = 23;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(83, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(96, 20);
            this.txtNombre.TabIndex = 22;
            // 
            // cmbPais
            // 
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(83, 114);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(92, 21);
            this.cmbPais.TabIndex = 21;
            // 
            // cmbApellido
            // 
            this.cmbApellido.FormattingEnabled = true;
            this.cmbApellido.Location = new System.Drawing.Point(83, 73);
            this.cmbApellido.Name = "cmbApellido";
            this.cmbApellido.Size = new System.Drawing.Size(93, 21);
            this.cmbApellido.TabIndex = 20;
            // 
            // cmbNombre
            // 
            this.cmbNombre.FormattingEnabled = true;
            this.cmbNombre.Location = new System.Drawing.Point(83, 34);
            this.cmbNombre.Name = "cmbNombre";
            this.cmbNombre.Size = new System.Drawing.Size(93, 21);
            this.cmbNombre.TabIndex = 19;
            // 
            // mtxtPuntaje
            // 
            this.mtxtPuntaje.Location = new System.Drawing.Point(83, 313);
            this.mtxtPuntaje.Mask = "1000";
            this.mtxtPuntaje.Name = "mtxtPuntaje";
            this.mtxtPuntaje.Size = new System.Drawing.Size(72, 20);
            this.mtxtPuntaje.TabIndex = 18;
            this.mtxtPuntaje.ValidatingType = typeof(int);
            // 
            // mtxtIngreso
            // 
            this.mtxtIngreso.Location = new System.Drawing.Point(83, 273);
            this.mtxtIngreso.Mask = "1000";
            this.mtxtIngreso.Name = "mtxtIngreso";
            this.mtxtIngreso.Size = new System.Drawing.Size(72, 20);
            this.mtxtIngreso.TabIndex = 17;
            this.mtxtIngreso.ValidatingType = typeof(int);
            // 
            // mtxtEdad
            // 
            this.mtxtEdad.Location = new System.Drawing.Point(83, 157);
            this.mtxtEdad.Mask = "99999";
            this.mtxtEdad.Name = "mtxtEdad";
            this.mtxtEdad.Size = new System.Drawing.Size(63, 20);
            this.mtxtEdad.TabIndex = 16;
            this.mtxtEdad.ValidatingType = typeof(int);
            // 
            // lblPaislogin
            // 
            this.lblPaislogin.AutoSize = true;
            this.lblPaislogin.Location = new System.Drawing.Point(23, 117);
            this.lblPaislogin.Name = "lblPaislogin";
            this.lblPaislogin.Size = new System.Drawing.Size(27, 13);
            this.lblPaislogin.TabIndex = 14;
            this.lblPaislogin.Text = "Pais";
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(23, 316);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(43, 13);
            this.lblPuntaje.TabIndex = 7;
            this.lblPuntaje.Text = "Puntaje";
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(23, 276);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(45, 13);
            this.lblIngreso.TabIndex = 5;
            this.lblIngreso.Text = "Ingreso ";
            // 
            // cmbSexo
            // 
            this.cmbSexo.Controls.Add(this.btnFemenino);
            this.cmbSexo.Controls.Add(this.optMasculino);
            this.cmbSexo.Location = new System.Drawing.Point(26, 199);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(223, 55);
            this.cmbSexo.TabIndex = 4;
            this.cmbSexo.TabStop = false;
            this.cmbSexo.Text = "Sexo";
            // 
            // btnFemenino
            // 
            this.btnFemenino.AutoSize = true;
            this.btnFemenino.Location = new System.Drawing.Point(107, 27);
            this.btnFemenino.Name = "btnFemenino";
            this.btnFemenino.Size = new System.Drawing.Size(71, 17);
            this.btnFemenino.TabIndex = 1;
            this.btnFemenino.TabStop = true;
            this.btnFemenino.Text = "Femenino";
            this.btnFemenino.UseVisualStyleBackColor = true;
            // 
            // optMasculino
            // 
            this.optMasculino.AutoSize = true;
            this.optMasculino.Location = new System.Drawing.Point(16, 27);
            this.optMasculino.Name = "optMasculino";
            this.optMasculino.Size = new System.Drawing.Size(73, 17);
            this.optMasculino.TabIndex = 0;
            this.optMasculino.TabStop = true;
            this.optMasculino.Text = "Masculino";
            this.optMasculino.UseVisualStyleBackColor = true;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(23, 157);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(23, 76);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(184, 488);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(73, 25);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(376, 519);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(78, 22);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // FrmCargarBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(466, 553);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cmbIniciar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmCargarBD";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmbIniciar.ResumeLayout(false);
            this.cmbIniciar.PerformLayout();
            this.cmbSexo.ResumeLayout(false);
            this.cmbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox cmbIniciar;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.GroupBox cmbSexo;
        private System.Windows.Forms.RadioButton btnFemenino;
        private System.Windows.Forms.RadioButton optMasculino;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblPaislogin;
        private System.Windows.Forms.MaskedTextBox mtxtPuntaje;
        private System.Windows.Forms.MaskedTextBox mtxtIngreso;
        private System.Windows.Forms.MaskedTextBox mtxtEdad;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbApellido;
        private System.Windows.Forms.ComboBox cmbNombre;
    }
}


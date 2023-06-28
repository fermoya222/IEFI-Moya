namespace pryMoyaIEFI
{
    partial class Form2
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
            this.lblPais = new System.Windows.Forms.Label();

            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnAggPais = new System.Windows.Forms.Button();
            this.txtPais = new System.Windows.Forms.TextBox();

            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnCargarPais = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(107, 98);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(27, 13);
            this.lblPais.TabIndex = 0;
            this.lblPais.Text = "Pais";
            // 


            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(158, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(67, 205);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(332, 264);
            this.dgv.TabIndex = 2;
            // 
            // btnAggPais
            // 
            this.btnAggPais.Location = new System.Drawing.Point(182, 143);
            this.btnAggPais.Name = "btnAggPais";
            this.btnAggPais.Size = new System.Drawing.Size(66, 25);
            this.btnAggPais.TabIndex = 3;
            this.btnAggPais.Text = "Agregar";
            this.btnAggPais.UseVisualStyleBackColor = true;
            this.btnAggPais.Click += new System.EventHandler(this.btnAggPais_Click);
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(150, 95);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(141, 20);
            this.txtPais.TabIndex = 4;
            // btnCargarPais
            // 
            this.btnCargarPais.Location = new System.Drawing.Point(193, 151);
            this.btnCargarPais.Name = "btnCargarPais";
            this.btnCargarPais.Size = new System.Drawing.Size(66, 25);
            this.btnCargarPais.TabIndex = 3;
            this.btnCargarPais.Text = "Cargar";
            this.btnCargarPais.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(466, 522);

            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.btnAggPais);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblPais);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Controls.Add(this.btnCargarPais);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblPais);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnAggPais;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.ComboBox comboBox1;
        //private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnCargarPais;
    }
}
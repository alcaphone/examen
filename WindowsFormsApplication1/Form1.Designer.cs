namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.BTO_MULT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_DATO_1 = new System.Windows.Forms.TextBox();
            this.TXT_DATO_2 = new System.Windows.Forms.TextBox();
            this.RESPUESTA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "INGRESE UN PRIMER NUMERO:";
            // 
            // BTO_MULT
            // 
            this.BTO_MULT.Location = new System.Drawing.Point(37, 287);
            this.BTO_MULT.Name = "BTO_MULT";
            this.BTO_MULT.Size = new System.Drawing.Size(101, 31);
            this.BTO_MULT.TabIndex = 1;
            this.BTO_MULT.Text = "MULTIPLICAR";
            this.BTO_MULT.UseVisualStyleBackColor = true;
            this.BTO_MULT.Click += new System.EventHandler(this.BTO_MULT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "INGRESE UN SEGUNDO NUMERO:";
            // 
            // TXT_DATO_1
            // 
            this.TXT_DATO_1.Location = new System.Drawing.Point(199, 199);
            this.TXT_DATO_1.Name = "TXT_DATO_1";
            this.TXT_DATO_1.Size = new System.Drawing.Size(50, 20);
            this.TXT_DATO_1.TabIndex = 3;
            // 
            // TXT_DATO_2
            // 
            this.TXT_DATO_2.Location = new System.Drawing.Point(199, 230);
            this.TXT_DATO_2.Name = "TXT_DATO_2";
            this.TXT_DATO_2.Size = new System.Drawing.Size(50, 20);
            this.TXT_DATO_2.TabIndex = 4;
            // 
            // RESPUESTA
            // 
            this.RESPUESTA.AutoSize = true;
            this.RESPUESTA.Location = new System.Drawing.Point(196, 287);
            this.RESPUESTA.Name = "RESPUESTA";
            this.RESPUESTA.Size = new System.Drawing.Size(13, 13);
            this.RESPUESTA.TabIndex = 5;
            this.RESPUESTA.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 342);
            this.Controls.Add(this.RESPUESTA);
            this.Controls.Add(this.TXT_DATO_2);
            this.Controls.Add(this.TXT_DATO_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTO_MULT);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTO_MULT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_DATO_1;
        private System.Windows.Forms.TextBox TXT_DATO_2;
        private System.Windows.Forms.Label RESPUESTA;
    }
}


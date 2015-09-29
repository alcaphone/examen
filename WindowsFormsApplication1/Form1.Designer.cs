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
            this.lbl_num = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.lbl_num1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Location = new System.Drawing.Point(505, 327);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(167, 13);
            this.lbl_num.TabIndex = 0;
            this.lbl_num.Text = "INGRESE EL PRIMER NUMERO";
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(704, 320);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(125, 20);
            this.txt_num.TabIndex = 1;
            this.txt_num.TextChanged += new System.EventHandler(this.txt_num_TextChanged);
            // 
            // txt_num1
            // 
            this.txt_num1.Location = new System.Drawing.Point(704, 383);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(125, 20);
            this.txt_num1.TabIndex = 2;
            // 
            // lbl_num1
            // 
            this.lbl_num1.AutoSize = true;
            this.lbl_num1.Location = new System.Drawing.Point(505, 383);
            this.lbl_num1.Name = "lbl_num1";
            this.lbl_num1.Size = new System.Drawing.Size(178, 13);
            this.lbl_num1.TabIndex = 3;
            this.lbl_num1.Text = "INGRESE EL SEGUNDO NUNERO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "RESTA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 536);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_num1);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.lbl_num);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.Label lbl_num1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}


namespace Acceso_A_datos_Martin_Scrocca
{
    partial class Form1
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
            this.btnListaComp = new System.Windows.Forms.Button();
            this.btnListaMayores_25 = new System.Windows.Forms.Button();
            this.btnBuscarApell = new System.Windows.Forms.Button();
            this.txtApell = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListaComp
            // 
            this.btnListaComp.Location = new System.Drawing.Point(290, 43);
            this.btnListaComp.Name = "btnListaComp";
            this.btnListaComp.Size = new System.Drawing.Size(145, 54);
            this.btnListaComp.TabIndex = 0;
            this.btnListaComp.Text = "Lista Completa";
            this.btnListaComp.UseVisualStyleBackColor = true;
            this.btnListaComp.Click += new System.EventHandler(this.BtnListaComp_Click);
            // 
            // btnListaMayores_25
            // 
            this.btnListaMayores_25.Location = new System.Drawing.Point(290, 159);
            this.btnListaMayores_25.Name = "btnListaMayores_25";
            this.btnListaMayores_25.Size = new System.Drawing.Size(145, 54);
            this.btnListaMayores_25.TabIndex = 1;
            this.btnListaMayores_25.Text = "Lista > 25 años";
            this.btnListaMayores_25.UseVisualStyleBackColor = true;
            this.btnListaMayores_25.Click += new System.EventHandler(this.BtnListaMayores_25_Click);
            // 
            // btnBuscarApell
            // 
            this.btnBuscarApell.Location = new System.Drawing.Point(290, 279);
            this.btnBuscarApell.Name = "btnBuscarApell";
            this.btnBuscarApell.Size = new System.Drawing.Size(145, 54);
            this.btnBuscarApell.TabIndex = 2;
            this.btnBuscarApell.Text = "Buscar Apellido";
            this.btnBuscarApell.UseVisualStyleBackColor = true;
            this.btnBuscarApell.Click += new System.EventHandler(this.BtnBuscarApell_Click);
            // 
            // txtApell
            // 
            this.txtApell.Location = new System.Drawing.Point(441, 297);
            this.txtApell.Name = "txtApell";
            this.txtApell.Size = new System.Drawing.Size(100, 20);
            this.txtApell.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(578, 365);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtApell);
            this.Controls.Add(this.btnBuscarApell);
            this.Controls.Add(this.btnListaMayores_25);
            this.Controls.Add(this.btnListaComp);
            this.Name = "Form1";
            this.Text = "Form Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListaComp;
        private System.Windows.Forms.Button btnListaMayores_25;
        private System.Windows.Forms.Button btnBuscarApell;
        private System.Windows.Forms.TextBox txtApell;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


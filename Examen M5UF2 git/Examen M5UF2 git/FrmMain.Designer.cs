namespace Examen_M5UF2_git
{
    partial class FrmMain
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
            this.btMenjar = new System.Windows.Forms.Button();
            this.btViatge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btMenjar
            // 
            this.btMenjar.BackColor = System.Drawing.Color.Cyan;
            this.btMenjar.Location = new System.Drawing.Point(259, 140);
            this.btMenjar.Name = "btMenjar";
            this.btMenjar.Size = new System.Drawing.Size(75, 23);
            this.btMenjar.TabIndex = 0;
            this.btMenjar.Text = "Menjar";
            this.btMenjar.UseVisualStyleBackColor = false;
            this.btMenjar.Click += new System.EventHandler(this.btMenjar_Click);
            // 
            // btViatge
            // 
            this.btViatge.BackColor = System.Drawing.Color.Yellow;
            this.btViatge.Location = new System.Drawing.Point(429, 140);
            this.btViatge.Name = "btViatge";
            this.btViatge.Size = new System.Drawing.Size(75, 23);
            this.btViatge.TabIndex = 1;
            this.btViatge.Text = "Viatge";
            this.btViatge.UseVisualStyleBackColor = false;
            this.btViatge.Click += new System.EventHandler(this.btViatge_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btViatge);
            this.Controls.Add(this.btMenjar);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btMenjar;
        private System.Windows.Forms.Button btViatge;
    }
}


namespace lab03p01
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(88, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 158);
            this.panel1.TabIndex = 0;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(272, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 158);
            this.panel2.TabIndex = 1;
            this.panel2.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(88, 213);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 157);
            this.panel3.TabIndex = 2;
            this.panel3.MouseEnter += new System.EventHandler(this.panel3_MouseEnter);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(277, 214);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(156, 155);
            this.panel4.TabIndex = 3;
            this.panel4.MouseEnter += new System.EventHandler(this.panel4_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}


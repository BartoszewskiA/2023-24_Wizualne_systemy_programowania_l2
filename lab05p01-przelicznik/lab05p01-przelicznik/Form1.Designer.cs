namespace lab05p01_przelicznik
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
            this.la_in = new System.Windows.Forms.Label();
            this.la_out = new System.Windows.Forms.Label();
            this.tb_in = new System.Windows.Forms.TextBox();
            this.tb_out = new System.Windows.Forms.TextBox();
            this.gb_in = new System.Windows.Forms.GroupBox();
            this.gb_out = new System.Windows.Forms.GroupBox();
            this.rb_in_pln = new System.Windows.Forms.RadioButton();
            this.rb_in_euro = new System.Windows.Forms.RadioButton();
            this.rb_in_usd = new System.Windows.Forms.RadioButton();
            this.rb_out_pln = new System.Windows.Forms.RadioButton();
            this.rb_out_euro = new System.Windows.Forms.RadioButton();
            this.rb_out_usd = new System.Windows.Forms.RadioButton();
            this.hsb_in = new System.Windows.Forms.HScrollBar();
            this.gb_in.SuspendLayout();
            this.gb_out.SuspendLayout();
            this.SuspendLayout();
            // 
            // la_in
            // 
            this.la_in.AutoSize = true;
            this.la_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.la_in.Location = new System.Drawing.Point(13, 26);
            this.la_in.Name = "la_in";
            this.la_in.Size = new System.Drawing.Size(49, 22);
            this.la_in.TabIndex = 0;
            this.la_in.Text = "WAL";
            // 
            // la_out
            // 
            this.la_out.AutoSize = true;
            this.la_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.la_out.Location = new System.Drawing.Point(12, 70);
            this.la_out.Name = "la_out";
            this.la_out.Size = new System.Drawing.Size(49, 22);
            this.la_out.TabIndex = 1;
            this.la_out.Text = "WAL";
            // 
            // tb_in
            // 
            this.tb_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_in.Location = new System.Drawing.Point(100, 23);
            this.tb_in.Name = "tb_in";
            this.tb_in.Size = new System.Drawing.Size(315, 28);
            this.tb_in.TabIndex = 2;
            // 
            // tb_out
            // 
            this.tb_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_out.Location = new System.Drawing.Point(100, 67);
            this.tb_out.Name = "tb_out";
            this.tb_out.Size = new System.Drawing.Size(315, 28);
            this.tb_out.TabIndex = 3;
            // 
            // gb_in
            // 
            this.gb_in.Controls.Add(this.rb_in_usd);
            this.gb_in.Controls.Add(this.rb_in_euro);
            this.gb_in.Controls.Add(this.rb_in_pln);
            this.gb_in.Location = new System.Drawing.Point(17, 134);
            this.gb_in.Name = "gb_in";
            this.gb_in.Size = new System.Drawing.Size(184, 139);
            this.gb_in.TabIndex = 4;
            this.gb_in.TabStop = false;
            this.gb_in.Text = "Waluta źródłowa";
            // 
            // gb_out
            // 
            this.gb_out.Controls.Add(this.rb_out_usd);
            this.gb_out.Controls.Add(this.rb_out_euro);
            this.gb_out.Controls.Add(this.rb_out_pln);
            this.gb_out.Location = new System.Drawing.Point(231, 134);
            this.gb_out.Name = "gb_out";
            this.gb_out.Size = new System.Drawing.Size(184, 139);
            this.gb_out.TabIndex = 5;
            this.gb_out.TabStop = false;
            this.gb_out.Text = "Waluta docelowa";
            // 
            // rb_in_pln
            // 
            this.rb_in_pln.AutoSize = true;
            this.rb_in_pln.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_in_pln.Location = new System.Drawing.Point(18, 33);
            this.rb_in_pln.Name = "rb_in_pln";
            this.rb_in_pln.Size = new System.Drawing.Size(63, 24);
            this.rb_in_pln.TabIndex = 0;
            this.rb_in_pln.TabStop = true;
            this.rb_in_pln.Text = "PLN";
            this.rb_in_pln.UseVisualStyleBackColor = true;
            this.rb_in_pln.CheckedChanged += new System.EventHandler(this.rb_in_pln_CheckedChanged);
            // 
            // rb_in_euro
            // 
            this.rb_in_euro.AutoSize = true;
            this.rb_in_euro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_in_euro.Location = new System.Drawing.Point(18, 63);
            this.rb_in_euro.Name = "rb_in_euro";
            this.rb_in_euro.Size = new System.Drawing.Size(78, 24);
            this.rb_in_euro.TabIndex = 1;
            this.rb_in_euro.TabStop = true;
            this.rb_in_euro.Text = "EURO";
            this.rb_in_euro.UseVisualStyleBackColor = true;
            this.rb_in_euro.CheckedChanged += new System.EventHandler(this.rb_in_euro_CheckedChanged);
            // 
            // rb_in_usd
            // 
            this.rb_in_usd.AutoSize = true;
            this.rb_in_usd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_in_usd.Location = new System.Drawing.Point(18, 93);
            this.rb_in_usd.Name = "rb_in_usd";
            this.rb_in_usd.Size = new System.Drawing.Size(66, 24);
            this.rb_in_usd.TabIndex = 2;
            this.rb_in_usd.TabStop = true;
            this.rb_in_usd.Text = "USD";
            this.rb_in_usd.UseVisualStyleBackColor = true;
            this.rb_in_usd.CheckedChanged += new System.EventHandler(this.rb_in_usd_CheckedChanged);
            // 
            // rb_out_pln
            // 
            this.rb_out_pln.AutoSize = true;
            this.rb_out_pln.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_out_pln.Location = new System.Drawing.Point(23, 32);
            this.rb_out_pln.Name = "rb_out_pln";
            this.rb_out_pln.Size = new System.Drawing.Size(63, 24);
            this.rb_out_pln.TabIndex = 0;
            this.rb_out_pln.TabStop = true;
            this.rb_out_pln.Text = "PLN";
            this.rb_out_pln.UseVisualStyleBackColor = true;
            this.rb_out_pln.CheckedChanged += new System.EventHandler(this.rb_out_pln_CheckedChanged);
            // 
            // rb_out_euro
            // 
            this.rb_out_euro.AutoSize = true;
            this.rb_out_euro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_out_euro.Location = new System.Drawing.Point(23, 63);
            this.rb_out_euro.Name = "rb_out_euro";
            this.rb_out_euro.Size = new System.Drawing.Size(78, 24);
            this.rb_out_euro.TabIndex = 1;
            this.rb_out_euro.TabStop = true;
            this.rb_out_euro.Text = "EURO";
            this.rb_out_euro.UseVisualStyleBackColor = true;
            this.rb_out_euro.CheckedChanged += new System.EventHandler(this.rb_out_euro_CheckedChanged);
            // 
            // rb_out_usd
            // 
            this.rb_out_usd.AutoSize = true;
            this.rb_out_usd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_out_usd.Location = new System.Drawing.Point(23, 93);
            this.rb_out_usd.Name = "rb_out_usd";
            this.rb_out_usd.Size = new System.Drawing.Size(66, 24);
            this.rb_out_usd.TabIndex = 2;
            this.rb_out_usd.TabStop = true;
            this.rb_out_usd.Text = "USD";
            this.rb_out_usd.UseVisualStyleBackColor = true;
            this.rb_out_usd.CheckedChanged += new System.EventHandler(this.rb_out_usd_CheckedChanged);
            // 
            // hsb_in
            // 
            this.hsb_in.LargeChange = 1;
            this.hsb_in.Location = new System.Drawing.Point(17, 280);
            this.hsb_in.Maximum = 10000;
            this.hsb_in.Name = "hsb_in";
            this.hsb_in.Size = new System.Drawing.Size(398, 28);
            this.hsb_in.TabIndex = 6;
            this.hsb_in.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsb_in_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(441, 332);
            this.Controls.Add(this.hsb_in);
            this.Controls.Add(this.gb_out);
            this.Controls.Add(this.gb_in);
            this.Controls.Add(this.tb_out);
            this.Controls.Add(this.tb_in);
            this.Controls.Add(this.la_out);
            this.Controls.Add(this.la_in);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Przelicznik walut";
            this.gb_in.ResumeLayout(false);
            this.gb_in.PerformLayout();
            this.gb_out.ResumeLayout(false);
            this.gb_out.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label la_in;
        private System.Windows.Forms.Label la_out;
        private System.Windows.Forms.TextBox tb_in;
        private System.Windows.Forms.TextBox tb_out;
        private System.Windows.Forms.GroupBox gb_in;
        private System.Windows.Forms.GroupBox gb_out;
        private System.Windows.Forms.RadioButton rb_in_usd;
        private System.Windows.Forms.RadioButton rb_in_euro;
        private System.Windows.Forms.RadioButton rb_in_pln;
        private System.Windows.Forms.RadioButton rb_out_usd;
        private System.Windows.Forms.RadioButton rb_out_euro;
        private System.Windows.Forms.RadioButton rb_out_pln;
        private System.Windows.Forms.HScrollBar hsb_in;
    }
}


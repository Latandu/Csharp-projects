namespace Szyfr_cezara
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDoZakodowania = new System.Windows.Forms.TextBox();
            this.txtTekstZakodowany = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numPrzesuniecie = new System.Windows.Forms.NumericUpDown();
            this.btnKoduj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPrzesuniecie)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tekst do zakodowania";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(603, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tekst zakodowany";
            // 
            // txtDoZakodowania
            // 
            this.txtDoZakodowania.Location = new System.Drawing.Point(47, 88);
            this.txtDoZakodowania.Multiline = true;
            this.txtDoZakodowania.Name = "txtDoZakodowania";
            this.txtDoZakodowania.Size = new System.Drawing.Size(219, 318);
            this.txtDoZakodowania.TabIndex = 2;
            // 
            // txtTekstZakodowany
            // 
            this.txtTekstZakodowany.Location = new System.Drawing.Point(536, 88);
            this.txtTekstZakodowany.Multiline = true;
            this.txtTekstZakodowany.Name = "txtTekstZakodowany";
            this.txtTekstZakodowany.Size = new System.Drawing.Size(219, 318);
            this.txtTekstZakodowany.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Przesunięcie";
            // 
            // numPrzesuniecie
            // 
            this.numPrzesuniecie.Location = new System.Drawing.Point(341, 229);
            this.numPrzesuniecie.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.numPrzesuniecie.Minimum = new decimal(new int[] {
            26,
            0,
            0,
            -2147483648});
            this.numPrzesuniecie.Name = "numPrzesuniecie";
            this.numPrzesuniecie.Size = new System.Drawing.Size(120, 20);
            this.numPrzesuniecie.TabIndex = 5;
            // 
            // btnKoduj
            // 
            this.btnKoduj.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKoduj.Location = new System.Drawing.Point(341, 271);
            this.btnKoduj.Name = "btnKoduj";
            this.btnKoduj.Size = new System.Drawing.Size(120, 86);
            this.btnKoduj.TabIndex = 6;
            this.btnKoduj.Text = "Koduj";
            this.btnKoduj.UseVisualStyleBackColor = true;
            this.btnKoduj.Click += new System.EventHandler(this.btnKoduj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKoduj);
            this.Controls.Add(this.numPrzesuniecie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTekstZakodowany);
            this.Controls.Add(this.txtDoZakodowania);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Szyfr Cezara";
            ((System.ComponentModel.ISupportInitialize)(this.numPrzesuniecie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDoZakodowania;
        private System.Windows.Forms.TextBox txtTekstZakodowany;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numPrzesuniecie;
        private System.Windows.Forms.Button btnKoduj;
    }
}


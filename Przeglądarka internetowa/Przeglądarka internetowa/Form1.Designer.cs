namespace Przeglądarka_internetowa
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
            this.btnWstecz = new System.Windows.Forms.Button();
            this.btnDalej = new System.Windows.Forms.Button();
            this.btnZatrzymaj = new System.Windows.Forms.Button();
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.btnUlubione = new System.Windows.Forms.Button();
            this.cmbUlubione = new System.Windows.Forms.ComboBox();
            this.brwOkno = new System.Windows.Forms.WebBrowser();
            this.btnIdz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWstecz
            // 
            this.btnWstecz.Location = new System.Drawing.Point(12, 10);
            this.btnWstecz.Name = "btnWstecz";
            this.btnWstecz.Size = new System.Drawing.Size(41, 26);
            this.btnWstecz.TabIndex = 0;
            this.btnWstecz.Text = "<";
            this.btnWstecz.UseVisualStyleBackColor = true;
            this.btnWstecz.Click += new System.EventHandler(this.btnWstecz_Click);
            // 
            // btnDalej
            // 
            this.btnDalej.Location = new System.Drawing.Point(61, 10);
            this.btnDalej.Name = "btnDalej";
            this.btnDalej.Size = new System.Drawing.Size(42, 26);
            this.btnDalej.TabIndex = 1;
            this.btnDalej.Text = ">";
            this.btnDalej.UseVisualStyleBackColor = true;
            this.btnDalej.Click += new System.EventHandler(this.btnDalej_Click);
            // 
            // btnZatrzymaj
            // 
            this.btnZatrzymaj.Location = new System.Drawing.Point(123, 10);
            this.btnZatrzymaj.Name = "btnZatrzymaj";
            this.btnZatrzymaj.Size = new System.Drawing.Size(44, 26);
            this.btnZatrzymaj.TabIndex = 2;
            this.btnZatrzymaj.Text = "X";
            this.btnZatrzymaj.UseVisualStyleBackColor = true;
            this.btnZatrzymaj.Click += new System.EventHandler(this.btnZatrzymaj_Click);
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Location = new System.Drawing.Point(173, 10);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(47, 26);
            this.btnOdswiez.TabIndex = 3;
            this.btnOdswiez.Text = "@";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            // 
            // txtAdres
            // 
            this.txtAdres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdres.Location = new System.Drawing.Point(226, 13);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(620, 20);
            this.txtAdres.TabIndex = 4;
            // 
            // btnUlubione
            // 
            this.btnUlubione.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUlubione.Location = new System.Drawing.Point(958, 12);
            this.btnUlubione.Name = "btnUlubione";
            this.btnUlubione.Size = new System.Drawing.Size(97, 23);
            this.btnUlubione.TabIndex = 6;
            this.btnUlubione.Text = "Add to favourites";
            this.btnUlubione.UseVisualStyleBackColor = true;
            this.btnUlubione.Click += new System.EventHandler(this.btnUlubione_Click);
            // 
            // cmbUlubione
            // 
            this.cmbUlubione.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUlubione.FormattingEnabled = true;
            this.cmbUlubione.Location = new System.Drawing.Point(1061, 13);
            this.cmbUlubione.Name = "cmbUlubione";
            this.cmbUlubione.Size = new System.Drawing.Size(286, 21);
            this.cmbUlubione.TabIndex = 7;
            this.cmbUlubione.SelectedIndexChanged += new System.EventHandler(this.cmbUlubione_SelectedIndexChanged);
            // 
            // brwOkno
            // 
            this.brwOkno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.brwOkno.Location = new System.Drawing.Point(2, 54);
            this.brwOkno.MinimumSize = new System.Drawing.Size(20, 20);
            this.brwOkno.Name = "brwOkno";
            this.brwOkno.Size = new System.Drawing.Size(1345, 768);
            this.brwOkno.TabIndex = 8;
            this.brwOkno.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.brwOkno_Navigated);
            // 
            // btnIdz
            // 
            this.btnIdz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIdz.Location = new System.Drawing.Point(852, 12);
            this.btnIdz.Name = "btnIdz";
            this.btnIdz.Size = new System.Drawing.Size(100, 23);
            this.btnIdz.TabIndex = 9;
            this.btnIdz.Text = "Go";
            this.btnIdz.UseVisualStyleBackColor = true;
            this.btnIdz.Click += new System.EventHandler(this.btnIdz_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 826);
            this.Controls.Add(this.btnIdz);
            this.Controls.Add(this.brwOkno);
            this.Controls.Add(this.cmbUlubione);
            this.Controls.Add(this.btnUlubione);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.btnZatrzymaj);
            this.Controls.Add(this.btnDalej);
            this.Controls.Add(this.btnWstecz);
            this.Name = "Form1";
            this.Text = "OhayoNET";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWstecz;
        private System.Windows.Forms.Button btnDalej;
        private System.Windows.Forms.Button btnZatrzymaj;
        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Button btnUlubione;
        private System.Windows.Forms.ComboBox cmbUlubione;
        private System.Windows.Forms.WebBrowser brwOkno;
        private System.Windows.Forms.Button btnIdz;
    }
}


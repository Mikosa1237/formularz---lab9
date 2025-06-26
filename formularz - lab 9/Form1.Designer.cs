namespace formularz___lab_9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);

            // ... existing code ...

            // ... existing code ...
        }

        #endregion

        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.TextBox txtNazwiskoImie;
        private System.Windows.Forms.TextBox txtSemestrRok;
        private System.Windows.Forms.TextBox txtKierunekStopien;
        private System.Windows.Forms.TextBox txtDataWniosku;
        private System.Windows.Forms.TextBox txtPrzedmiot;
        private System.Windows.Forms.TextBox txtPunkty;
        private System.Windows.Forms.TextBox txtProwadzacy;
        private System.Windows.Forms.TextBox txtUzasadnienie;
        private System.Windows.Forms.TextBox txtDataPodpisStudenta;
        private System.Windows.Forms.TextBox txtKomisja1;
        private System.Windows.Forms.TextBox txtKomisja2;
        private System.Windows.Forms.TextBox txtKomisja3;
        private System.Windows.Forms.TextBox txtDataDecyzji;
        private System.Windows.Forms.TextBox txtPieczatkaPodpis;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnZaladuj;
    }
}

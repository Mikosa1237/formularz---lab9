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
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.txtNazwiskoImie = new System.Windows.Forms.TextBox();
            this.txtSemestrRok = new System.Windows.Forms.TextBox();
            this.txtKierunekStopien = new System.Windows.Forms.TextBox();
            this.txtDataWniosku = new System.Windows.Forms.TextBox();
            this.txtPrzedmiot = new System.Windows.Forms.TextBox();
            this.txtPunkty = new System.Windows.Forms.TextBox();
            this.txtProwadzacy = new System.Windows.Forms.TextBox();
            this.txtUzasadnienie = new System.Windows.Forms.TextBox();
            this.txtDataPodpisStudenta = new System.Windows.Forms.TextBox();
            this.txtKomisja1 = new System.Windows.Forms.TextBox();
            this.txtKomisja2 = new System.Windows.Forms.TextBox();
            this.txtKomisja3 = new System.Windows.Forms.TextBox();
            this.txtDataDecyzji = new System.Windows.Forms.TextBox();
            this.txtPieczatkaPodpis = new System.Windows.Forms.TextBox();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnZaladuj = new System.Windows.Forms.Button();
            this.btnWybierzBaze = new System.Windows.Forms.Button();
            this.lblSciezkaBazy = new System.Windows.Forms.Label();

            // Etykiety
            string[] labels = {
                "Numer albumu", "Nazwisko i imię", "Semestr, rok", "Kierunek i stopień studiów", "Data wniosku", "Przedmiot", "Punkty", "Prowadzący", "Uzasadnienie", "Data i podpis studenta", "Komisja 1", "Komisja 2", "Komisja 3", "Data decyzji", "Pieczątka i podpis"
            };
            System.Windows.Forms.Label[] labelControls = new System.Windows.Forms.Label[15];
            System.Windows.Forms.TextBox[] textBoxes = {
                txtAlbum, txtNazwiskoImie, txtSemestrRok, txtKierunekStopien, txtDataWniosku, txtPrzedmiot, txtPunkty, txtProwadzacy, txtUzasadnienie, txtDataPodpisStudenta, txtKomisja1, txtKomisja2, txtKomisja3, txtDataDecyzji, txtPieczatkaPodpis
            };
            int y = 20;
            int labelWidth = 180;
            int boxWidth = 250;
            int height = 24;
            int gap = 32;
            for (int i = 0; i < 15; i++)
            {
                labelControls[i] = new System.Windows.Forms.Label();
                labelControls[i].Text = labels[i];
                labelControls[i].Left = 20;
                labelControls[i].Top = y;
                labelControls[i].Width = labelWidth;
                textBoxes[i].Left = 20 + labelWidth + 10;
                textBoxes[i].Top = y;
                textBoxes[i].Width = boxWidth;
                textBoxes[i].Height = height;
                this.Controls.Add(labelControls[i]);
                this.Controls.Add(textBoxes[i]);
                y += gap;
            }
            // Przyciski
            btnZapisz.Text = "Zapisz do bazy";
            btnZapisz.Left = 20;
            btnZapisz.Top = y + 10;
            btnZapisz.Width = 120;
            btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            btnZaladuj.Text = "Załaduj z bazy";
            btnZaladuj.Left = 160;
            btnZaladuj.Top = y + 10;
            btnZaladuj.Width = 120;
            btnZaladuj.Click += new System.EventHandler(this.btnZaladuj_Click);
            this.Controls.Add(btnZapisz);
            this.Controls.Add(btnZaladuj);
            // Dodaję przycisk wyboru bazy i label na końcu
            this.btnWybierzBaze = new System.Windows.Forms.Button();
            this.lblSciezkaBazy = new System.Windows.Forms.Label();
            this.btnWybierzBaze.Text = "Wybierz bazę danych";
            this.btnWybierzBaze.Left = 320;
            this.btnWybierzBaze.Top = this.btnZapisz.Top;
            this.btnWybierzBaze.Width = 150;
            this.btnWybierzBaze.Click += new System.EventHandler(this.btnWybierzBaze_Click);
            this.Controls.Add(this.btnWybierzBaze);
            this.lblSciezkaBazy.Text = "";
            this.lblSciezkaBazy.Left = 20;
            this.lblSciezkaBazy.Top = this.btnZapisz.Top + 40;
            this.lblSciezkaBazy.Width = 450;
            this.Controls.Add(this.lblSciezkaBazy);
            //
            this.ClientSize = new System.Drawing.Size(520, y + 60);
            this.Text = "Wniosek o egzamin komisyjny";
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
        private System.Windows.Forms.Button btnWybierzBaze;
        private System.Windows.Forms.Label lblSciezkaBazy;
    }
}

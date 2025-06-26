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
            // Inicjalizacja kontrolek
            this.btnWybierzBaze = new System.Windows.Forms.Button();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.lblNazwiskoImie = new System.Windows.Forms.Label();
            this.txtNazwiskoImie = new System.Windows.Forms.TextBox();
            this.lblSemestrRok = new System.Windows.Forms.Label();
            this.txtSemestrRok = new System.Windows.Forms.TextBox();
            this.lblKierunekStopien = new System.Windows.Forms.Label();
            this.txtKierunekStopien = new System.Windows.Forms.TextBox();
            this.lblDataWniosku = new System.Windows.Forms.Label();
            this.txtDataWniosku = new System.Windows.Forms.TextBox();
            this.lblPrzedmiot = new System.Windows.Forms.Label();
            this.txtPrzedmiot = new System.Windows.Forms.TextBox();
            this.lblPunkty = new System.Windows.Forms.Label();
            this.txtPunkty = new System.Windows.Forms.TextBox();
            this.lblProwadzacy = new System.Windows.Forms.Label();
            this.txtProwadzacy = new System.Windows.Forms.TextBox();
            this.lblUzasadnienie = new System.Windows.Forms.Label();
            this.txtUzasadnienie = new System.Windows.Forms.TextBox();
            this.lblDataPodpisStudenta = new System.Windows.Forms.Label();
            this.txtDataPodpisStudenta = new System.Windows.Forms.TextBox();
            this.lblKomisja1 = new System.Windows.Forms.Label();
            this.txtKomisja1 = new System.Windows.Forms.TextBox();
            this.lblKomisja2 = new System.Windows.Forms.Label();
            this.txtKomisja2 = new System.Windows.Forms.TextBox();
            this.lblKomisja3 = new System.Windows.Forms.Label();
            this.txtKomisja3 = new System.Windows.Forms.TextBox();
            this.lblDataDecyzji = new System.Windows.Forms.Label();
            this.txtDataDecyzji = new System.Windows.Forms.TextBox();
            this.lblPieczatkaPodpis = new System.Windows.Forms.Label();
            this.txtPieczatkaPodpis = new System.Windows.Forms.TextBox();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnZaladuj = new System.Windows.Forms.Button();

            // Przycisk wyboru bazy
            this.btnWybierzBaze.Text = "Wybierz bazę danych";
            this.btnWybierzBaze.Left = 20;
            this.btnWybierzBaze.Top = 10;
            this.btnWybierzBaze.Width = 180;
            this.btnWybierzBaze.Click += new System.EventHandler(this.btnWybierzBaze_Click);
            this.Controls.Add(this.btnWybierzBaze);

            // Ustawienia pozycji i rozmiarów
            int y = 50;
            int labelWidth = 180;
            int boxWidth = 250;
            int height = 24;
            int gap = 32;
            int sectionGap = 18;

            // Numer albumu
            this.lblAlbum.Text = "Numer albumu";
            this.lblAlbum.Left = 20;
            this.lblAlbum.Top = y;
            this.lblAlbum.Width = labelWidth;
            this.txtAlbum.Left = 20 + labelWidth + 10;
            this.txtAlbum.Top = y;
            this.txtAlbum.Width = boxWidth;
            this.txtAlbum.Height = height;
            y += gap;
            // Nazwisko i imię
            this.lblNazwiskoImie.Text = "Nazwisko i imię";
            this.lblNazwiskoImie.Left = 20;
            this.lblNazwiskoImie.Top = y;
            this.lblNazwiskoImie.Width = labelWidth;
            this.txtNazwiskoImie.Left = 20 + labelWidth + 10;
            this.txtNazwiskoImie.Top = y;
            this.txtNazwiskoImie.Width = boxWidth;
            this.txtNazwiskoImie.Height = height;
            y += gap;
            // Semestr, rok
            this.lblSemestrRok.Text = "Semestr, rok";
            this.lblSemestrRok.Left = 20;
            this.lblSemestrRok.Top = y;
            this.lblSemestrRok.Width = labelWidth;
            this.txtSemestrRok.Left = 20 + labelWidth + 10;
            this.txtSemestrRok.Top = y;
            this.txtSemestrRok.Width = boxWidth;
            this.txtSemestrRok.Height = height;
            y += gap;
            // Kierunek i stopień studiów
            this.lblKierunekStopien.Text = "Kierunek i stopień studiów";
            this.lblKierunekStopien.Left = 20;
            this.lblKierunekStopien.Top = y;
            this.lblKierunekStopien.Width = labelWidth;
            this.txtKierunekStopien.Left = 20 + labelWidth + 10;
            this.txtKierunekStopien.Top = y;
            this.txtKierunekStopien.Width = boxWidth;
            this.txtKierunekStopien.Height = height;
            y += gap + sectionGap;
            // Data wniosku
            this.lblDataWniosku.Text = "Data wniosku";
            this.lblDataWniosku.Left = 20;
            this.lblDataWniosku.Top = y;
            this.lblDataWniosku.Width = labelWidth;
            this.txtDataWniosku.Left = 20 + labelWidth + 10;
            this.txtDataWniosku.Top = y;
            this.txtDataWniosku.Width = boxWidth;
            this.txtDataWniosku.Height = height;
            y += gap;
            // Przedmiot
            this.lblPrzedmiot.Text = "Przedmiot";
            this.lblPrzedmiot.Left = 20;
            this.lblPrzedmiot.Top = y;
            this.lblPrzedmiot.Width = labelWidth;
            this.txtPrzedmiot.Left = 20 + labelWidth + 10;
            this.txtPrzedmiot.Top = y;
            this.txtPrzedmiot.Width = boxWidth;
            this.txtPrzedmiot.Height = height;
            y += gap;
            // Punkty
            this.lblPunkty.Text = "Punkty";
            this.lblPunkty.Left = 20;
            this.lblPunkty.Top = y;
            this.lblPunkty.Width = labelWidth;
            this.txtPunkty.Left = 20 + labelWidth + 10;
            this.txtPunkty.Top = y;
            this.txtPunkty.Width = boxWidth;
            this.txtPunkty.Height = height;
            y += gap;
            // Prowadzący
            this.lblProwadzacy.Text = "Prowadzący";
            this.lblProwadzacy.Left = 20;
            this.lblProwadzacy.Top = y;
            this.lblProwadzacy.Width = labelWidth;
            this.txtProwadzacy.Left = 20 + labelWidth + 10;
            this.txtProwadzacy.Top = y;
            this.txtProwadzacy.Width = boxWidth;
            this.txtProwadzacy.Height = height;
            y += gap + sectionGap;
            // Uzasadnienie
            this.lblUzasadnienie.Text = "Uzasadnienie";
            this.lblUzasadnienie.Left = 20;
            this.lblUzasadnienie.Top = y;
            this.lblUzasadnienie.Width = labelWidth;
            this.txtUzasadnienie.Left = 20 + labelWidth + 10;
            this.txtUzasadnienie.Top = y;
            this.txtUzasadnienie.Width = boxWidth;
            this.txtUzasadnienie.Height = height * 2;
            y += gap * 2 + sectionGap;
            // Data i podpis studenta
            this.lblDataPodpisStudenta.Text = "Data i podpis studenta";
            this.lblDataPodpisStudenta.Left = 20;
            this.lblDataPodpisStudenta.Top = y;
            this.lblDataPodpisStudenta.Width = labelWidth;
            this.txtDataPodpisStudenta.Left = 20 + labelWidth + 10;
            this.txtDataPodpisStudenta.Top = y;
            this.txtDataPodpisStudenta.Width = boxWidth;
            this.txtDataPodpisStudenta.Height = height;
            y += gap;
            // Komisja 1
            this.lblKomisja1.Text = "Komisja 1";
            this.lblKomisja1.Left = 20;
            this.lblKomisja1.Top = y;
            this.lblKomisja1.Width = labelWidth;
            this.txtKomisja1.Left = 20 + labelWidth + 10;
            this.txtKomisja1.Top = y;
            this.txtKomisja1.Width = boxWidth;
            this.txtKomisja1.Height = height;
            y += gap;
            // Komisja 2
            this.lblKomisja2.Text = "Komisja 2";
            this.lblKomisja2.Left = 20;
            this.lblKomisja2.Top = y;
            this.lblKomisja2.Width = labelWidth;
            this.txtKomisja2.Left = 20 + labelWidth + 10;
            this.txtKomisja2.Top = y;
            this.txtKomisja2.Width = boxWidth;
            this.txtKomisja2.Height = height;
            y += gap;
            // Komisja 3
            this.lblKomisja3.Text = "Komisja 3";
            this.lblKomisja3.Left = 20;
            this.lblKomisja3.Top = y;
            this.lblKomisja3.Width = labelWidth;
            this.txtKomisja3.Left = 20 + labelWidth + 10;
            this.txtKomisja3.Top = y;
            this.txtKomisja3.Width = boxWidth;
            this.txtKomisja3.Height = height;
            y += gap + sectionGap;
            // Data decyzji
            this.lblDataDecyzji.Text = "Data decyzji";
            this.lblDataDecyzji.Left = 20;
            this.lblDataDecyzji.Top = y;
            this.lblDataDecyzji.Width = labelWidth;
            this.txtDataDecyzji.Left = 20 + labelWidth + 10;
            this.txtDataDecyzji.Top = y;
            this.txtDataDecyzji.Width = boxWidth;
            this.txtDataDecyzji.Height = height;
            y += gap;
            // Pieczątka i podpis
            this.lblPieczatkaPodpis.Text = "Pieczątka i podpis";
            this.lblPieczatkaPodpis.Left = 20;
            this.lblPieczatkaPodpis.Top = y;
            this.lblPieczatkaPodpis.Width = labelWidth;
            this.txtPieczatkaPodpis.Left = 20 + labelWidth + 10;
            this.txtPieczatkaPodpis.Top = y;
            this.txtPieczatkaPodpis.Width = boxWidth;
            this.txtPieczatkaPodpis.Height = height;
            y += gap;

            // Przyciski
            this.btnZapisz.Text = "Zapisz do bazy";
            this.btnZapisz.Left = 20;
            this.btnZapisz.Top = y + 10;
            this.btnZapisz.Width = 120;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            this.btnZaladuj.Text = "Załaduj z bazy";
            this.btnZaladuj.Left = 160;
            this.btnZaladuj.Top = y + 10;
            this.btnZaladuj.Width = 120;
            this.btnZaladuj.Click += new System.EventHandler(this.btnZaladuj_Click);

            // Dodanie do Controls
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.lblNazwiskoImie);
            this.Controls.Add(this.txtNazwiskoImie);
            this.Controls.Add(this.lblSemestrRok);
            this.Controls.Add(this.txtSemestrRok);
            this.Controls.Add(this.lblKierunekStopien);
            this.Controls.Add(this.txtKierunekStopien);
            this.Controls.Add(this.lblDataWniosku);
            this.Controls.Add(this.txtDataWniosku);
            this.Controls.Add(this.lblPrzedmiot);
            this.Controls.Add(this.txtPrzedmiot);
            this.Controls.Add(this.lblPunkty);
            this.Controls.Add(this.txtPunkty);
            this.Controls.Add(this.lblProwadzacy);
            this.Controls.Add(this.txtProwadzacy);
            this.Controls.Add(this.lblUzasadnienie);
            this.Controls.Add(this.txtUzasadnienie);
            this.Controls.Add(this.lblDataPodpisStudenta);
            this.Controls.Add(this.txtDataPodpisStudenta);
            this.Controls.Add(this.lblKomisja1);
            this.Controls.Add(this.txtKomisja1);
            this.Controls.Add(this.lblKomisja2);
            this.Controls.Add(this.txtKomisja2);
            this.Controls.Add(this.lblKomisja3);
            this.Controls.Add(this.txtKomisja3);
            this.Controls.Add(this.lblDataDecyzji);
            this.Controls.Add(this.txtDataDecyzji);
            this.Controls.Add(this.lblPieczatkaPodpis);
            this.Controls.Add(this.txtPieczatkaPodpis);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.btnZaladuj);

            // Ustawienia formularza
            this.ClientSize = new System.Drawing.Size(520, y + 60);
            this.Text = "Wniosek o egzamin komisyjny";
        }

        #endregion

        private System.Windows.Forms.Button btnWybierzBaze;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Label lblNazwiskoImie;
        private System.Windows.Forms.TextBox txtNazwiskoImie;
        private System.Windows.Forms.Label lblSemestrRok;
        private System.Windows.Forms.TextBox txtSemestrRok;
        private System.Windows.Forms.Label lblKierunekStopien;
        private System.Windows.Forms.TextBox txtKierunekStopien;
        private System.Windows.Forms.Label lblDataWniosku;
        private System.Windows.Forms.TextBox txtDataWniosku;
        private System.Windows.Forms.Label lblPrzedmiot;
        private System.Windows.Forms.TextBox txtPrzedmiot;
        private System.Windows.Forms.Label lblPunkty;
        private System.Windows.Forms.TextBox txtPunkty;
        private System.Windows.Forms.Label lblProwadzacy;
        private System.Windows.Forms.TextBox txtProwadzacy;
        private System.Windows.Forms.Label lblUzasadnienie;
        private System.Windows.Forms.TextBox txtUzasadnienie;
        private System.Windows.Forms.Label lblDataPodpisStudenta;
        private System.Windows.Forms.TextBox txtDataPodpisStudenta;
        private System.Windows.Forms.Label lblKomisja1;
        private System.Windows.Forms.Label lblKomisja2;
        private System.Windows.Forms.Label lblKomisja3;
        private System.Windows.Forms.Label lblDataDecyzji;
        private System.Windows.Forms.Label lblPieczatkaPodpis;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.TextBox txtDataDecyzji;
        private System.Windows.Forms.TextBox txtPieczatkaPodpis;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnZaladuj;
    }
}

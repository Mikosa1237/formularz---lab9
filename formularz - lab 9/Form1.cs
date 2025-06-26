using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace formularz___lab_9
{
    public partial class Form1 : Form
    {
        private string dbPath = "egzamin_komisyjny.db";
        private string connStr => $"Data Source={dbPath};Version=3;";

        public Form1()
        {
            InitializeComponent();
            CreateDatabaseIfNotExists();
        }

        private void CreateDatabaseIfNotExists()
        {
            using (var conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                string sql = @"CREATE TABLE IF NOT EXISTS WnioskiEgzaminKomisyjny (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Album TEXT, NazwiskoImie TEXT, SemestrRok TEXT, KierunekStopien TEXT,
                    DataWniosku TEXT, Przedmiot TEXT, Punkty TEXT, Prowadzacy TEXT,
                    Uzasadnienie TEXT, DataPodpisStudenta TEXT,
                    Komisja1 TEXT, Komisja2 TEXT, Komisja3 TEXT,
                    DataDecyzji TEXT, PieczatkaPodpis TEXT,
                    DataDodania DATETIME DEFAULT CURRENT_TIMESTAMP
                )";
                new SQLiteCommand(sql, conn).ExecuteNonQuery();
            }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            using (var conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                string sql = @"INSERT INTO WnioskiEgzaminKomisyjny
                    (Album, NazwiskoImie, SemestrRok, KierunekStopien, DataWniosku, Przedmiot, Punkty, Prowadzacy, Uzasadnienie, DataPodpisStudenta, Komisja1, Komisja2, Komisja3, DataDecyzji, PieczatkaPodpis)
                    VALUES (@Album, @NazwiskoImie, @SemestrRok, @KierunekStopien, @DataWniosku, @Przedmiot, @Punkty, @Prowadzacy, @Uzasadnienie, @DataPodpisStudenta, @Komisja1, @Komisja2, @Komisja3, @DataDecyzji, @PieczatkaPodpis)";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Album", txtAlbum.Text);
                cmd.Parameters.AddWithValue("@NazwiskoImie", txtNazwiskoImie.Text);
                cmd.Parameters.AddWithValue("@SemestrRok", txtSemestrRok.Text);
                cmd.Parameters.AddWithValue("@KierunekStopien", txtKierunekStopien.Text);
                cmd.Parameters.AddWithValue("@DataWniosku", txtDataWniosku.Text);
                cmd.Parameters.AddWithValue("@Przedmiot", txtPrzedmiot.Text);
                cmd.Parameters.AddWithValue("@Punkty", txtPunkty.Text);
                cmd.Parameters.AddWithValue("@Prowadzacy", txtProwadzacy.Text);
                cmd.Parameters.AddWithValue("@Uzasadnienie", txtUzasadnienie.Text);
                cmd.Parameters.AddWithValue("@DataPodpisStudenta", txtDataPodpisStudenta.Text);
                cmd.Parameters.AddWithValue("@Komisja1", txtKomisja1.Text);
                cmd.Parameters.AddWithValue("@Komisja2", txtKomisja2.Text);
                cmd.Parameters.AddWithValue("@Komisja3", txtKomisja3.Text);
                cmd.Parameters.AddWithValue("@DataDecyzji", txtDataDecyzji.Text);
                cmd.Parameters.AddWithValue("@PieczatkaPodpis", txtPieczatkaPodpis.Text);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Zapisano do bazy!");
            ClearFields();
        }

        private void btnZaladuj_Click(object sender, EventArgs e)
        {
            using (var conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT Id, NazwiskoImie, Przedmiot, DataDodania FROM WnioskiEgzaminKomisyjny ORDER BY DataDodania DESC";
                var da = new SQLiteDataAdapter(sql, conn);
                var dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Brak zapisanych wniosków.");
                    return;
                }

                var selectForm = new Form { Width = 400, Height = 300, Text = "Wybierz wniosek" };
                var listBox = new ListBox { Dock = DockStyle.Fill };
                foreach (DataRow row in dt.Rows)
                    listBox.Items.Add($"{row["Id"]}: {row["NazwiskoImie"]} - {row["Przedmiot"]} ({row["DataDodania"]})");
                selectForm.Controls.Add(listBox);

                var btnLoad = new Button { Text = "Załaduj", Dock = DockStyle.Bottom };
                selectForm.Controls.Add(btnLoad);

                btnLoad.Click += (s, ev) =>
                {
                    if (listBox.SelectedIndex >= 0)
                    {
                        int id = int.Parse(listBox.SelectedItem.ToString().Split(':')[0]);
                        LoadRecord(id);
                        selectForm.Close();
                    }
                };
                selectForm.ShowDialog();
            }
        }

        private void LoadRecord(int id)
        {
            using (var conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM WnioskiEgzaminKomisyjny WHERE Id=@Id";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtAlbum.Text = reader["Album"].ToString();
                    txtNazwiskoImie.Text = reader["NazwiskoImie"].ToString();
                    txtSemestrRok.Text = reader["SemestrRok"].ToString();
                    txtKierunekStopien.Text = reader["KierunekStopien"].ToString();
                    txtDataWniosku.Text = reader["DataWniosku"].ToString();
                    txtPrzedmiot.Text = reader["Przedmiot"].ToString();
                    txtPunkty.Text = reader["Punkty"].ToString();
                    txtProwadzacy.Text = reader["Prowadzacy"].ToString();
                    txtUzasadnienie.Text = reader["Uzasadnienie"].ToString();
                    txtDataPodpisStudenta.Text = reader["DataPodpisStudenta"].ToString();
                    txtKomisja1.Text = reader["Komisja1"].ToString();
                    txtKomisja2.Text = reader["Komisja2"].ToString();
                    txtKomisja3.Text = reader["Komisja3"].ToString();
                    txtDataDecyzji.Text = reader["DataDecyzji"].ToString();
                    txtPieczatkaPodpis.Text = reader["PieczatkaPodpis"].ToString();
                }
            }
        }

        private void ClearFields()
        {
            txtAlbum.Clear();
            txtNazwiskoImie.Clear();
            txtSemestrRok.Clear();
            txtKierunekStopien.Clear();
            txtDataWniosku.Clear();
            txtPrzedmiot.Clear();
            txtPunkty.Clear();
            txtProwadzacy.Clear();
            txtUzasadnienie.Clear();
            txtDataPodpisStudenta.Clear();
            txtKomisja1.Clear();
            txtKomisja2.Clear();
            txtKomisja3.Clear();
            txtDataDecyzji.Clear();
            txtPieczatkaPodpis.Clear();
        }
    }
}

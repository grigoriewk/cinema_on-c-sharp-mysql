using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace kinoteatr_bd_forms
{
    public partial class reference : Form
    {
        public reference()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            Update_comboBox();
        }

        Bitmap bmp;

        private void Search_film(string selectedFilm)
        {
            using (var connect_db = new MySqlConnection(
                $"server = 127.0.0.1; port = 3306; username=root; password=1234; database = cinema_db"))
            {

                //2 - Название
                //3 - Жанр
                //4 - Страна производства
                //5 - Продюсер

                //6 - Название кинотеатра
                //7 - Категория
                //8 - Район
                //9 - Вместимость

                //10 - Цена билета
                //11 - Свободных мест
                //12 - Номер зала
                //13 - Сеанс
                connect_db.Open();
                label1.Text += "  '" + selectedFilm + "'";
                string queryForSelectFilm = "select id_ticket,name_film, genre, country_from, producer, name_cinema, " +
                "category, district, roominess, price, free_places, hall_num, session from film left join cinema on " +
                $"(cinema.id_cinema=film.id_cinema) left join ticket on (ticket.id_film=film.id_film) where film.name_film='{selectedFilm}' group by film.name_film order by id_ticket asc";
                var query = connect_db.Query<tables>(queryForSelectFilm);
                foreach (var a in query)
                {
                    label2.Text += a.name_film;
                    label3.Text += a.genre;
                    label4.Text += a.country_from;
                    label5.Text += a.producer;

                    label6.Text += a.name_cinema;
                    label7.Text += a.category;
                    label8.Text += a.district;
                    label9.Text += a.roominess;

                    label10.Text += a.price;
                    label11.Text += a.free_places;
                    label12.Text += a.hall_num;
                    label13.Text += a.session;
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width-130, this.Size.Height-65, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X+120, this.Location.Y+130, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }
        
        private void Update_comboBox()
        {
            comboBox1.Items.Clear();
            using (var connect_db = new MySqlConnection(
                $"server = 127.0.0.1; port = 3306; username=root; password=1234; database = cinema_db"))
            {
                connect_db.Open();
                var query = connect_db.Query<tables>("select name_film from film");
                foreach (var a in query)
                    comboBox1.Items.Add(a.name_film);
                connect_db.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearLabels();
            string selectedFilm = comboBox1.SelectedItem.ToString();
            Search_film(selectedFilm);
            groupBox1.Visible = true;
        }

        private void ClearLabels()
        {
            label1.Text = "СПРАВКА О ФИЛЬМЕ";
            label2.Text = "Название: ";
            label3.Text = "Жанр: ";
            label4.Text = "Страна производства: ";
            label5.Text = "Продюсер: ";
            label6.Text = "В кинотеатре: ";
            label7.Text = "Категория: ";
            label8.Text = "Район: ";
            label9.Text = "Вместимость: ";
            label10.Text = "Цена билета: ";
            label11.Text = "Свободных мест: ";
            label12.Text = "Номер зала: ";
            label13.Text = "Сеанс: ";
        }

    }
}

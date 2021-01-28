using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace kinoteatr_bd_forms
{
    public partial class kinoteatr : Form
    {
        public kinoteatr()
        {
            InitializeComponent();
            ActiveControl = textBox2;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
        }

        string queryForSelect = "select id_ticket,name_film, genre, country_from, producer, name_cinema, " +
                           "category, district, roominess, price, free_places, hall_num, session from film left join cinema on " +
                           "(cinema.id_cinema=film.id_cinema) left join ticket on (ticket.id_film=film.id_film) order by id_ticket asc";
        string[] s = new string[13];

        private void update_dgv()
        {
            var connect_db = new MySqlConnection(
                $"server = 127.0.0.1; port = 3306; username={textBox2.Text}; password={textBox1.Text}; database = cinema_db");
            var query = connect_db.Query<tables>(queryForSelect);
            foreach (var a in query)
                dataGridView4.Rows.Add(a.id_ticket, a.name_film, a.genre, a.country_from, a.producer, a.name_cinema,
                    a.category, a.district, a.roominess, a.price, a.free_places, a.hall_num, a.session);
        }

        private void button1_Click(object sender, EventArgs e) //login
        {

            using (var connect_db = new MySqlConnection(
                $"server = 127.0.0.1; port = 3306; username={textBox2.Text}; password={textBox1.Text}; database = cinema_db"))
            {
                try
                {
                    label6.Text = "Ваша роль: ";
                    label8.Text = "Ваши привилегии: ";
                    label9.Text = "Пустое значение поля ID и других ячеек говорит об отсутствии данного фильма в прокате.";

                    groupBox2.Visible = true;
                    groupBox3.Visible = true;
                    groupBox4.Visible = true;

                    dataGridView4.Rows.Clear();
                    label3.Visible = true;
                    label4.Visible = false;
                    label7.Visible = false;

                    connect_db.Open();

                    if (textBox2.Text == "worker")
                    {
                        label6.Text += "Работник";
                        label8.Text += "Просматривать и редактировать часть базы данных";
                        toolStrip1.Visible = true;
                        button3.Visible = false;
                    }
                    else if (textBox2.Text == "root")
                    {
                        label6.Text += "Администратор";
                        label8.Text += "Редактирование всей базы данных";
                        toolStrip1.Visible = true;
                        button3.Visible = true;
                    }
                    else if (textBox2.Text == "user")
                    {
                        label6.Text += "Пользователь";
                        label8.Text += "Ничего. Только смотреть.";
                        toolStrip1.Visible = false;
                        button3.Visible = false;
                    }

                    update_dgv();
                    connect_db.Close();
                }
                catch {
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    groupBox4.Visible = false;
                    label4.Visible = true; 
                    label7.Visible = true;
                    label3.Visible = false;
                }
            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox1.Focus();
                e.SuppressKeyPress = true;
            }
        }
        private void button2_Click(object sender, EventArgs e) //search
        {
            reference spravka = new reference();
            spravka.Show();
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button2.PerformClick();
        }

        private void toolStripButton1_Click(object sender, EventArgs e) //insert
        {
            using (var connect_db = new MySqlConnection(
                    $"server = 127.0.0.1; port = 3306; username={textBox2.Text}; password={textBox1.Text}; database = cinema_db"))
            {
                connect_db.Open();

                string[] s = new string[13];
                for (int i = 0; i < 13; ++i)
                    s[i] = (string)dataGridView4.SelectedCells[i].Value;
                if (textBox2.Text != "root" && ( s[5] != null || s[6] != null || s[7] != null || s[7] != null))
                {
                    MessageBox.Show("Вы не имеете права добавлять кинотеатры", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    string query1 = $"insert into cinema (name_cinema, category, district, roominess) values " +
                               $"('{s[5]}','{s[6]}', '{s[7]}', '{s[8]}');";
                    string query2 = $"insert into film (name_film, genre, country_from, producer, id_cinema) values " +
                            $"('{s[1]}','{s[2]}', '{s[3]}', '{s[4]}', (select id_cinema from cinema where cinema.name_cinema='{s[5]}'));";
                    string query3 = $"insert into ticket (price, free_places, hall_num, session, id_film) values (price='{s[9]}', free_places='{s[10]}', hall_num='{s[11]}', session='{s[12]}', " +
                        $"id_film=(select id_film from film where id_cinema=(select id_cinema from cinema where (name_cinema='{s[5]}' && category='{s[6]}' && district='{s[7]}'))))";
                    if (s[0] == null)
                    {
                        connect_db.Query<tables>(query3);
                        MessageBox.Show("Фильм в прокате!", "Системное уведомление", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else 
                    {
                        connect_db.Query<tables>(query1);
                        connect_db.Query<tables>(query2);
                        connect_db.Query<tables>(query3);
                        MessageBox.Show("Данные обновлены", "Системное уведомление",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                connect_db.Close();
            }


        }

        private void toolStripButton2_Click(object sender, EventArgs e) //delete
        {
            try
            {
                using (var connect_db = new MySqlConnection(
                    $"server = 127.0.0.1; port = 3306; username={textBox2.Text}; password={textBox1.Text}; database = cinema_db"))
                {
                    for (int i = 0; i < 13; ++i)
                        s[i] = (string)dataGridView4.SelectedCells[i].Value;
                    if (textBox2.Text == "worker" && (s[5] != null || s[6] != null || s[7] != null || s[7] != null))
                    {
                        MessageBox.Show("Вы не имеете права снимать фильм с проката", "Ошибка изменения",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        connect_db.Open();
                        var result = MessageBox.Show("Вы уверены?", "Удаление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            string query = $"delete from ticket where id_ticket={s[0]}";

                            connect_db.Query<tables>(query);
                            MessageBox.Show("Фильм выведен из проката", "Выполнено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        dataGridView4.Rows.Clear();
                        update_dgv();
                        connect_db.Close();
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Данный запрос выполнить невозможно", 
                MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void toolStripButton3_Click(object sender, EventArgs e) //update
        {
            using (var connect_db = new MySqlConnection(
                    $"server = 127.0.0.1; port = 3306; username={textBox2.Text}; password={textBox1.Text}; database = cinema_db"))
            {
                connect_db.Open();
                for (int i = 0; i < 13; ++i)
                    s[i] = (string)dataGridView4.SelectedCells[i].Value;
                
                if (s[0] == null)
                        MessageBox.Show("Нельзя выполнить обновление данных, поскольку данный фильм снят с проката", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    for (int i = 0; i < 13; ++i)
                    {
                        if (s[i] == null)
                        {
                            MessageBox.Show("Заполните все ячейки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                    if (textBox2.Text == "worker" && (s[1] != null || s[2] != null || s[3] != null || s[4] != null
                        || s[5] != null || s[6] != null || s[7] != null || s[8] != null))
                    {
                        MessageBox.Show("Вы не можете обновлять данные", "Ошибка изменения",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string query1 = $"update cinema set name_cinema='{s[5]}', category='{s[6]}', district='{s[7]}', roominess='{s[8]}' " +
                            $"where id_cinema=(select id_cinema from film where id_film=(select id_film from ticket where id_ticket={s[0]}))";
                        string query2 = $"update film set name_film='{s[1]}', genre='{s[2]}', country_from='{s[3]}', producer='{s[4]}' " +
                            $"where id_film=(select id_film from ticket where id_ticket={s[0]})";
                        string query3 = $"update ticket set price='{s[9]}', free_places='{s[10]}', hall_num='{s[11]}', session='{s[12]}', " +
                            $"id_film=(select id_film from film where id_cinema=(select id_cinema from cinema where (name_cinema='{s[5]}' && category='{s[6]}' && district='{s[7]}'))) where id_ticket={s[0]}";
                        string query4 = $"select id_ticket from ticket where id_ticket='{s[0]}'";
                        try
                        {
                            if (Convert.ToInt32(connect_db.ExecuteScalar(query4)) != 0)
                            {
                                connect_db.Query<tables>(query1);
                                connect_db.Query<tables>(query2);
                                connect_db.Query<tables>(query3);
                                MessageBox.Show("Успешно!", "Системное уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex) { MessageBox.Show("Успешно!","Системное уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    }
                }
                connect_db.Close();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e) //sell
        {
            using (var connect_db = new MySqlConnection(
                $"server = 127.0.0.1; port = 3306; username={textBox2.Text}; password={textBox1.Text}; database = cinema_db"))
            {
                for (int i = 0; i < 13; ++i)
                    s[i] = (string)dataGridView4.SelectedCells[i].Value;
                if (s[9] == null || s[10] == null || s[11] == null || s[12] == null)
                {
                    MessageBox.Show("На данный фильм нет билетов, так как он не в прокате", "Системное уведомление",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    connect_db.Open();
                    string query1 = $"update ticket set free_places=free_places-1 where id_ticket={s[0]}";
                    connect_db.Query<tables>(query1);
                    dataGridView4.Rows.Clear();
                    update_dgv();
                    connect_db.Close();
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e) //delete confirm
        {
            groupBox5.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e) //delete film and cinema
        {
            using (var connect_db = new MySqlConnection(
                $"server = 127.0.0.1; port = 3306; username={textBox2.Text}; password={textBox1.Text}; database = cinema_db"))
            {
                connect_db.Open();

                if (textBox4.Text != "Название фильма" && textBox4.Text != null) {
                    string query = $"delete from film where name_film='{textBox4.Text}'";
                    connect_db.Query<tables>(query); 
                }

                if (textBox5.Text != "Название кинотеатра" && textBox5.Text != null) {
                    string query = $"delete from cinema where name_cinema='{textBox5.Text}'";
                    connect_db.Query<tables>(query);
                }

                dataGridView4.Rows.Clear();
                update_dgv();

                connect_db.Close();
            }
        }
    }
}
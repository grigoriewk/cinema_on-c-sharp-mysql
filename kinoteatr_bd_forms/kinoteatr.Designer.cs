namespace kinoteatr_bd_forms
{
    partial class kinoteatr
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kinoteatr));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.id_cinema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_film = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country_from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_cinema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.district = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roominess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.free_places = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hall_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.session = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите пароль";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(6, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 24);
            this.textBox1.TabIndex = 3;
            this.textBox1.UseSystemPasswordChar = true;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(6, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Авторизоваться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Успешно!";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Проблема с подключением.";
            this.label4.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(6, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 24);
            this.textBox2.TabIndex = 12;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 236);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Проверьте введенные данные.";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(17, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ваша роль: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView4);
            this.groupBox2.Location = new System.Drawing.Point(12, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1397, 521);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView4
            // 
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cinema,
            this.name_film,
            this.genre,
            this.country_from,
            this.producer,
            this.name_cinema,
            this.category,
            this.district,
            this.roominess,
            this.price,
            this.free_places,
            this.hall_num,
            this.session});
            this.dataGridView4.Location = new System.Drawing.Point(9, 17);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 30;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(1372, 498);
            this.dataGridView4.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(275, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 236);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 44);
            this.button3.TabIndex = 16;
            this.button3.Text = "Удалить данные";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 44);
            this.button2.TabIndex = 15;
            this.button2.Text = "Получить справку о фильме";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(531, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(878, 237);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.textBox5);
            this.groupBox5.Controls.Add(this.textBox4);
            this.groupBox5.Location = new System.Drawing.Point(20, 80);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(384, 118);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Удаление";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(249, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 44);
            this.button4.TabIndex = 17;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(6, 73);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(200, 24);
            this.textBox5.TabIndex = 15;
            this.textBox5.Text = "Название кинотеатра";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(6, 32);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 24);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "Название фильма";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(17, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(17, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ваши привилегии:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1435, 31);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "Вставить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton2.Text = "Удалить из проката";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton3.Text = "Обновить";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton4.Text = "Продать билет";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // id_cinema
            // 
            this.id_cinema.HeaderText = "ID";
            this.id_cinema.MinimumWidth = 6;
            this.id_cinema.Name = "id_cinema";
            this.id_cinema.ReadOnly = true;
            this.id_cinema.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_cinema.Width = 45;
            // 
            // name_film
            // 
            this.name_film.HeaderText = "Название фильма";
            this.name_film.MinimumWidth = 6;
            this.name_film.Name = "name_film";
            this.name_film.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name_film.Width = 120;
            // 
            // genre
            // 
            this.genre.HeaderText = "Жанр";
            this.genre.MinimumWidth = 6;
            this.genre.Name = "genre";
            this.genre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.genre.Width = 120;
            // 
            // country_from
            // 
            this.country_from.HeaderText = "Страна производства";
            this.country_from.MinimumWidth = 6;
            this.country_from.Name = "country_from";
            this.country_from.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.country_from.Width = 90;
            // 
            // producer
            // 
            this.producer.HeaderText = "Продюсер";
            this.producer.MinimumWidth = 6;
            this.producer.Name = "producer";
            this.producer.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.producer.Width = 90;
            // 
            // name_cinema
            // 
            this.name_cinema.HeaderText = "Название кинотеатра";
            this.name_cinema.MinimumWidth = 6;
            this.name_cinema.Name = "name_cinema";
            this.name_cinema.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name_cinema.Width = 70;
            // 
            // category
            // 
            this.category.HeaderText = "Категория";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.category.Width = 70;
            // 
            // district
            // 
            this.district.HeaderText = "Район";
            this.district.MinimumWidth = 6;
            this.district.Name = "district";
            this.district.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.district.Width = 90;
            // 
            // roominess
            // 
            this.roominess.HeaderText = "Количество мест";
            this.roominess.MinimumWidth = 6;
            this.roominess.Name = "roominess";
            this.roominess.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.roominess.Width = 70;
            // 
            // price
            // 
            this.price.HeaderText = "Цена билета";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.price.Width = 60;
            // 
            // free_places
            // 
            this.free_places.HeaderText = "Свободные места";
            this.free_places.MinimumWidth = 6;
            this.free_places.Name = "free_places";
            this.free_places.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.free_places.Width = 60;
            // 
            // hall_num
            // 
            this.hall_num.HeaderText = "Номер зала";
            this.hall_num.MinimumWidth = 6;
            this.hall_num.Name = "hall_num";
            this.hall_num.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.hall_num.Width = 60;
            // 
            // session
            // 
            this.session.HeaderText = "Сеанс";
            this.session.MinimumWidth = 6;
            this.session.Name = "session";
            this.session.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.session.Width = 52;
            // 
            // kinoteatr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 793);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kinoteatr";
            this.Text = "Справочная служба кинотеатра";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cinema;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_film;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn country_from;
        private System.Windows.Forms.DataGridViewTextBoxColumn producer;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_cinema;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn district;
        private System.Windows.Forms.DataGridViewTextBoxColumn roominess;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn free_places;
        private System.Windows.Forms.DataGridViewTextBoxColumn hall_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn session;
    }
}


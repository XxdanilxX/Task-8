namespace Task_8
{
    public partial class frmStruct : Form
    {
        public frmStruct()
        {
            InitializeComponent();
            cmbPost.Items.Add("Преподаватель");
            cmbPost.Items.Add("Ст.преподаватель");
            cmbPost.Items.Add("Доцент");
            cmbPost.Items.Add("Профессор");
            cmbDegree.Items.Add("Без уч.степени");
            cmbDegree.Items.Add("Кандидат наук");
            cmbDegree.Items.Add("Доктор наук");
            dgvDannye.ColumnCount = 5;
            dgvDannye.Columns[0].HeaderText = "ФИО";
            dgvDannye.Columns[1].HeaderText = "Должность";
            dgvDannye.Columns[2].HeaderText = "Дата рождения";
            dgvDannye.Columns[3].HeaderText = "Ученая степень";
            dgvDannye.Columns[4].HeaderText = "Стаж";
            dgvDannye.RowHeadersVisible = false;
            dgvVyborka.ColumnCount = 5;
            dgvVyborka.Columns[0].HeaderText = "ФИО";
            dgvVyborka.Columns[1].HeaderText = "Должность";
            dgvVyborka.Columns[2].HeaderText = "Дата рождения";
            dgvVyborka.Columns[3].HeaderText = "Ученая степень";
            dgvVyborka.Columns[4].HeaderText = "Стаж";

            dgvVyborka.RowHeadersVisible = false;
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].HeaderText = "Марка";
            dataGridView1.Columns[1].HeaderText = "Вартість";
            dataGridView1.RowHeadersVisible = false;
            dataGridView2.ColumnCount = 2;
            dataGridView2.Columns[0].HeaderText = "Марка"; ;
            dataGridView2.Columns[1].HeaderText = "Середня Вартість";
            dataGridView2.RowHeadersVisible = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPost.Items.Add("Преподаватель");
            cmbPost.Items.Add("Ст.преподаватель");
            cmbPost.Items.Add("Доцент");
            cmbPost.Items.Add("Профессор");
            cmbDegree.Items.Add("Без уч.степени");
            cmbDegree.Items.Add("Кандидат наук");
            cmbDegree.Items.Add("Доктор наук");
            dgvDannye.ColumnCount = 5;
            dgvDannye.Columns[0].HeaderText = "ФИО";
            dgvDannye.Columns[1].HeaderText = "Должность";
            dgvDannye.Columns[2].HeaderText = "Дата рождения";
            dgvDannye.Columns[3].HeaderText = "Ученая степень";
            dgvDannye.Columns[4].HeaderText = "Стаж";
            dgvDannye.RowHeadersVisible = false;
            dgvVyborka.ColumnCount = 5;
            dgvVyborka.Columns[0].HeaderText = "ФИО";
            dgvVyborka.Columns[1].HeaderText = "Должность";
            dgvVyborka.Columns[2].HeaderText = "Дата рождения";
            dgvVyborka.Columns[3].HeaderText = "Ученая степень";
            dgvVyborka.Columns[4].HeaderText = "Стаж";

            dgvVyborka.RowHeadersVisible = false;
        }

        private void btAdd1_Click(object sender, EventArgs e)
        {

            if (txtExperience.Text == "" || txtFIO.Text == "" ||
                cmbDegree.SelectedIndex == -1 || cmbPost.SelectedIndex == -1)
            {
                MessageBox.Show("Не все данные выбраны!", "Ошибка!");
            }
            else
            {
                worker[i].FIO = txtFIO.Text;
                worker[i].Post = cmbPost.Text;
                worker[i].Date_of_Birth = dtpBirth.Value.ToString("dd.MM.yyyy");
                worker[i].Degree = cmbDegree.Text;
                worker[i].Experience = Convert.ToInt32(txtExperience.Text);
                dgvDannye.Rows.Add(worker[i].FIO, worker[i].Post,
                    worker[i].Date_of_Birth, worker[i].Degree,
                    worker[i].Experience.ToString());
                i++;
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (txtZapros.Text == "")
            {
                MessageBox.Show("Запрос не может быть выполнен!", "Ошибка");
            }
            else
            {
                if (rbtZapros1.Checked == true)
                {
                    dgvVyborka.Rows.Clear();
                    int select1 = Convert.ToInt32(txtZapros.Text);
                    foreach (Employee wSel in worker)
                    {
                        if (wSel.Experience >= select1)
                        {
                            dgvVyborka.Rows.Add(wSel.FIO, wSel.Post, wSel.Date_of_Birth,
                                wSel.Degree, wSel.Experience.ToString());
                        }
                    }
                }
                if (rbtZapros2.Checked == true)
                {
                    dgvVyborka.Rows.Clear();
                    string select2 = txtZapros.Text;
                    foreach (Employee wSel in worker)
                    {
                        if (wSel.Post == select2)
                        {
                            dgvVyborka.Rows.Add(wSel.FIO, wSel.Post, wSel.Degree,
                                wSel.Experience.ToString());
                        }
                    }
                }
            }
        }
        

        struct Employee
        {
            public string FIO;
            public string Post;
            public string Date_of_Birth;
            public string Degree;
            public int Experience;
        }
        Employee[] worker = new Employee[20];
        int i = 0;
        struct Avto
        {
            public string Marka;
            public int Value;
        }
        Avto[] avto = new Avto[20];
        int i_ = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Не все данные выбраны!", "Ошибка!");
            }
            else
            {
                avto[i_].Marka = textBox1.Text;
                avto[i_].Value = Convert.ToInt32(textBox2.Text);
                dataGridView1.Rows.Add(avto[i_].Marka, avto[i_].Value.ToString());
                i_++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Запрос не может быть выполнен!", "Ошибка");
            }
            else
            {
                dataGridView2.Rows.Clear();
                string select1 = textBox3.Text;
                int n = 0;
                int SumValue = 0;
                string marka = "";
                foreach (Avto wSel in avto)
                {
                    if (wSel.Marka == select1)
                    {
                        n += 1;
                        SumValue += wSel.Value;
                        marka += wSel.Marka.ToString();
                    }
                }
                dataGridView2.Rows.Add(marka, SumValue / n);


            }
        }
       

        private void добавитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btAdd1_Click(sender, e);
        }

        private void виполнитьЗапросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btSearch_Click(sender, e);
        }



        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void додатиДаніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void шукатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }
    }

}


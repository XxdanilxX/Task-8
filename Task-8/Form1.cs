namespace Task_8
{
    public partial class frmStruct : Form
    {
        public frmStruct()
        {
            InitializeComponent();
            cmbPost.Items.Add("�������������");
            cmbPost.Items.Add("��.�������������");
            cmbPost.Items.Add("������");
            cmbPost.Items.Add("���������");
            cmbDegree.Items.Add("��� ��.�������");
            cmbDegree.Items.Add("�������� ����");
            cmbDegree.Items.Add("������ ����");
            dgvDannye.ColumnCount = 5;
            dgvDannye.Columns[0].HeaderText = "���";
            dgvDannye.Columns[1].HeaderText = "���������";
            dgvDannye.Columns[2].HeaderText = "���� ��������";
            dgvDannye.Columns[3].HeaderText = "������ �������";
            dgvDannye.Columns[4].HeaderText = "����";
            dgvDannye.RowHeadersVisible = false;
            dgvVyborka.ColumnCount = 5;
            dgvVyborka.Columns[0].HeaderText = "���";
            dgvVyborka.Columns[1].HeaderText = "���������";
            dgvVyborka.Columns[2].HeaderText = "���� ��������";
            dgvVyborka.Columns[3].HeaderText = "������ �������";
            dgvVyborka.Columns[4].HeaderText = "����";

            dgvVyborka.RowHeadersVisible = false;
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].HeaderText = "�����";
            dataGridView1.Columns[1].HeaderText = "�������";
            dataGridView1.RowHeadersVisible = false;
            dataGridView2.ColumnCount = 2;
            dataGridView2.Columns[0].HeaderText = "�����"; ;
            dataGridView2.Columns[1].HeaderText = "������� �������";
            dataGridView2.RowHeadersVisible = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPost.Items.Add("�������������");
            cmbPost.Items.Add("��.�������������");
            cmbPost.Items.Add("������");
            cmbPost.Items.Add("���������");
            cmbDegree.Items.Add("��� ��.�������");
            cmbDegree.Items.Add("�������� ����");
            cmbDegree.Items.Add("������ ����");
            dgvDannye.ColumnCount = 5;
            dgvDannye.Columns[0].HeaderText = "���";
            dgvDannye.Columns[1].HeaderText = "���������";
            dgvDannye.Columns[2].HeaderText = "���� ��������";
            dgvDannye.Columns[3].HeaderText = "������ �������";
            dgvDannye.Columns[4].HeaderText = "����";
            dgvDannye.RowHeadersVisible = false;
            dgvVyborka.ColumnCount = 5;
            dgvVyborka.Columns[0].HeaderText = "���";
            dgvVyborka.Columns[1].HeaderText = "���������";
            dgvVyborka.Columns[2].HeaderText = "���� ��������";
            dgvVyborka.Columns[3].HeaderText = "������ �������";
            dgvVyborka.Columns[4].HeaderText = "����";

            dgvVyborka.RowHeadersVisible = false;
        }

        private void btAdd1_Click(object sender, EventArgs e)
        {

            if (txtExperience.Text == "" || txtFIO.Text == "" ||
                cmbDegree.SelectedIndex == -1 || cmbPost.SelectedIndex == -1)
            {
                MessageBox.Show("�� ��� ������ �������!", "������!");
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
                MessageBox.Show("������ �� ����� ���� ��������!", "������");
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
                MessageBox.Show("�� ��� ������ �������!", "������!");
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
                MessageBox.Show("������ �� ����� ���� ��������!", "������");
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
       

        private void ��������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btAdd1_Click(sender, e);
        }

        private void ���������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btSearch_Click(sender, e);
        }



        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void �����ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }
    }

}


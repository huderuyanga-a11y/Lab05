using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboDepartment.SelectedIndex = 0;

            label2.Text = "Нийт: 0";

            UpdateProgress();
        }

        // =========================
        // НЭР ӨӨРЧЛӨГДӨХ
        // =========================
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        // =========================
        // НАС АВТОМАТААР БОДОХ
        // =========================
        private void dateBirth_ValueChanged(object sender, EventArgs e)
        {
            int age = DateTime.Today.Year - dateBirth.Value.Year;

            if (dateBirth.Value.Date > DateTime.Today.AddYears(-age))
                age--;

            if (age >= numericAge.Minimum &&
                age <= numericAge.Maximum)
            {
                numericAge.Value = age;
            }

            UpdateProgress();
        }

        // =========================
        // УТАС
        // =========================
        private void maskedPhone_MaskInputRejected(
            object sender,
            MaskInputRejectedEventArgs e)
        {
            MessageBox.Show(
                "Утасны дугаарыг зөв оруулна уу.",
                "Анхааруулга",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        // =========================
        // ХЭЛ
        // =========================
        private void languageList_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            UpdateProgress();
        }

        // =========================
        // ХИЧЭЭЛ
        // =========================
        private void checkedListBox1_ItemCheck(
            object sender,
            ItemCheckEventArgs e)
        {
            BeginInvoke(new Action(UpdateProgress));
        }

        // =========================
        // ТЭНХИМ
        // =========================
        private void comboDepartment_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            UpdateProgress();
        }

        // =========================
        // TREEVIEW
        // =========================
        private void treeView1_AfterSelect(
            object sender,
            TreeViewEventArgs e)
        {
            int index = comboDepartment.Items.IndexOf(e.Node.Text);

            if (index > 0)
            {
                comboDepartment.SelectedIndex = index;
            }
        }

        // =========================
        // ЗУРАГ СОНГОХ
        // =========================
        private void pictureBox1_Click(
            object sender,
            EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter =
                    "Зураг|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                ofd.Title = "Цээж зураг сонгох";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (pictureBox1.Image != null)
                        {
                            pictureBox1.Image.Dispose();
                            pictureBox1.Image = null;
                        }

                        using (Image temp = Image.FromFile(ofd.FileName))
                        {
                            pictureBox1.Image = new Bitmap(temp);
                        }

                        pictureBox1.SizeMode =
                            PictureBoxSizeMode.Zoom;

                        UpdateProgress();
                    }
                    catch
                    {
                        MessageBox.Show(
                            "Зургийг оруулахад алдаа гарлаа.",
                            "Алдаа",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        // =========================
        // БҮРТГЭХ
        // =========================
        private void button1_Click(
            object sender,
            EventArgs e)
        {
            // Нэр шалгах
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show(
                    "Овог нэрээ оруулна уу.",
                    "Анхааруулга",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBox1.Focus();
                return;
            }

            // Утас шалгах
            if (maskedPhone.Text.Contains(" "))
            {
                MessageBox.Show(
                    "Утасны дугаараа оруулна уу.",
                    "Анхааруулга",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                maskedPhone.Focus();
                return;
            }

            // Тэнхим шалгах
            if (comboDepartment.SelectedIndex <= 0)
            {
                MessageBox.Show(
                    "Тэнхимээ сонгоно уу.",
                    "Анхааруулга",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                comboDepartment.Focus();
                return;
            }

            // Хэл шалгах
            if (languageList.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Хэл сонгоно уу.",
                    "Анхааруулга",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                languageList.Focus();
                return;
            }

            // ListView-д нэмэх
            ListViewItem item = new ListViewItem(textBox1.Text);

            item.SubItems.Add(maskedPhone.Text);
            item.SubItems.Add(numericAge.Value.ToString());

            item.Tag = textBox1.Text;

            listView1.Items.Add(item);

            // Нийт тоо
            label2.Text =
                "Нийт:" + listView1.Items.Count;

            // Мэдээлэл харуулах
            richTextBox1.Clear();

            richTextBox1.AppendText(
                "Овог нэр: " +
                textBox1.Text + Environment.NewLine);

            richTextBox1.AppendText(
                "Утас: " +
                maskedPhone.Text + Environment.NewLine);

            richTextBox1.AppendText(
                "Нас: " +
                numericAge.Value + Environment.NewLine);

            richTextBox1.AppendText(
                "Тэнхим: " +
                comboDepartment.Text + Environment.NewLine);

            if (languageList.SelectedItem != null)
            {
                richTextBox1.AppendText(
                    "Хэл: " +
                    languageList.SelectedItem +
                    Environment.NewLine);
            }

            richTextBox1.AppendText(
                "Төрсөн огноо: " +
                dateBirth.Value.ToShortDateString() +
                Environment.NewLine);

            richTextBox1.AppendText(
                "Сургалт: " +
                (radioButton1.Checked
                    ? "Өдрийн сургалт"
                    : "Сонгоогүй") +
                Environment.NewLine);

            richTextBox1.AppendText(
                "Тэтгэлэгтэй: " +
                (checkBox1.Checked
                    ? "Тийм"
                    : "Үгүй"));

            MessageBox.Show(
                "Оюутан амжилттай бүртгэгдлээ.",
                "Бүртгэл",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            UpdateProgress();
        }

        // =========================
        // LISTVIEW СОНГОХ
        // =========================
        private void listView1_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                ListViewItem item =
                    listView1.SelectedItems[0];

                richTextBox1.Clear();

                richTextBox1.AppendText(
                    "Овог нэр: " +
                    item.SubItems[0].Text +
                    Environment.NewLine);

                richTextBox1.AppendText(
                    "Утас: " +
                    item.SubItems[1].Text +
                    Environment.NewLine);

                richTextBox1.AppendText(
                    "Нас: " +
                    item.SubItems[2].Text);
            }
        }

        // =========================
        // ЦЭВЭРЛЭХ
        // =========================
        private void linkLabel1_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            textBox1.Clear();

            checkBox1.Checked = false;

            radioButton1.Checked = false;

            for (int i = 0;
                 i < checkedListBox1.Items.Count;
                 i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

            numericAge.Value = 18;

            comboDepartment.SelectedIndex = 0;

            maskedPhone.Clear();

            dateBirth.Value =
                new DateTime(2008, 9, 28);

            languageList.ClearSelected();

            richTextBox1.Clear();

            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }

            UpdateProgress();
        }

        // =========================
        // LABEL
        // =========================
        private void label2_Click(
            object sender,
            EventArgs e)
        {
        }

        // =========================
        // PROGRESS
        // =========================
        private void UpdateProgress()
        {
            int total = 0;

            if (!string.IsNullOrWhiteSpace(textBox1.Text))
                total++;

            if (checkBox1.Checked)
                total++;

            if (radioButton1.Checked)
                total++;

            if (checkedListBox1.CheckedItems.Count > 0)
                total++;

            if (languageList.SelectedIndex >= 0)
                total++;

            if (comboDepartment.SelectedIndex > 0)
                total++;

            if (!string.IsNullOrWhiteSpace(maskedPhone.Text))
                total++;

            if (pictureBox1.Image != null)
                total++;

            progressBar1.Value =
                Math.Min(total * 12, 100);
        }

        private void Form1_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
namespace Lab05
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox textBox1;
        private Label label2;
        private LinkLabel linkLabel1;
        private CheckBox checkBox1;
        private RadioButton radioButton1;
        private CheckedListBox checkedListBox1;
        private NumericUpDown numericAge;
        private ComboBox comboDepartment;
        private MaskedTextBox maskedPhone;
        private DateTimePicker dateBirth;
        private ListBox languageList;

        private PictureBox pictureBox1;
        private TreeView treeView1;
        private RichTextBox richTextBox1;
        private Button button1;
        private Label labelPicture;
        private Label labelProgress;
        private ProgressBar progressBar1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TreeNode treeNode13 = new TreeNode("Мэдээллийн технологи");
            TreeNode treeNode14 = new TreeNode("Програм хангамж");
            TreeNode treeNode15 = new TreeNode("Компьютерын ухаан", new TreeNode[] { treeNode13, treeNode14 });
            TreeNode treeNode16 = new TreeNode("Математик");
            TreeNode treeNode17 = new TreeNode("Физик");
            TreeNode treeNode18 = new TreeNode("Байгалийн ухааны сургууль", new TreeNode[] { treeNode16, treeNode17 });
            textBox1 = new TextBox();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            checkBox1 = new CheckBox();
            radioButton1 = new RadioButton();
            checkedListBox1 = new CheckedListBox();
            numericAge = new NumericUpDown();
            comboDepartment = new ComboBox();
            maskedPhone = new MaskedTextBox();
            dateBirth = new DateTimePicker();
            languageList = new ListBox();
            pictureBox1 = new PictureBox();
            treeView1 = new TreeView();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            labelPicture = new Label();
            labelProgress = new Label();
            progressBar1 = new ProgressBar();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numericAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            textBox1.Text = "M.IT24D015";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 27);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 1;
            label2.Text = "Нийт: 0";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(360, 27);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(87, 25);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Цэвэрлэх";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(28, 76);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(126, 29);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Тэтгэлэгтэй";
            checkBox1.CheckedChanged += textBox1_TextChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(28, 111);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(167, 29);
            radioButton1.TabIndex = 4;
            radioButton1.Text = "Өдрийн сургалт";
            radioButton1.CheckedChanged += textBox1_TextChanged;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Программчлал", "Өгөгдлийн бүтэц", "Алгоритм", "Өгөгдлийн сан", "Сүлжээ" });
            checkedListBox1.Location = new Point(26, 160);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(180, 144);
            checkedListBox1.TabIndex = 5;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            // 
            // numericAge
            // 
            numericAge.Location = new Point(26, 331);
            numericAge.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericAge.Name = "numericAge";
            numericAge.Size = new Size(180, 31);
            numericAge.TabIndex = 7;
            numericAge.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // comboDepartment
            // 
            comboDepartment.FormattingEnabled = true;
            comboDepartment.Items.AddRange(new object[] { "-- Тэнхим сонгох --", "Компьютерын ухаан", "Мэдээллийн технологи", "Програм хангамж", "Математик", "Физик" });
            comboDepartment.Location = new Point(24, 439);
            comboDepartment.Name = "comboDepartment";
            comboDepartment.Size = new Size(182, 33);
            comboDepartment.TabIndex = 8;
            comboDepartment.Text = "-- Тэнхим сонгох --";
            comboDepartment.SelectedIndexChanged += comboDepartment_SelectedIndexChanged;
            // 
            // maskedPhone
            // 
            maskedPhone.Location = new Point(24, 483);
            maskedPhone.Mask = "0000-0000";
            maskedPhone.Name = "maskedPhone";
            maskedPhone.Size = new Size(150, 31);
            maskedPhone.TabIndex = 9;
            maskedPhone.Text = "99999999";
            maskedPhone.MaskInputRejected += maskedPhone_MaskInputRejected;
            maskedPhone.TextChanged += textBox1_TextChanged;
            // 
            // dateBirth
            // 
            dateBirth.Format = DateTimePickerFormat.Short;
            dateBirth.Location = new Point(24, 520);
            dateBirth.Name = "dateBirth";
            dateBirth.Size = new Size(201, 31);
            dateBirth.TabIndex = 10;
            dateBirth.Value = new DateTime(2008, 9, 28, 0, 0, 0, 0);
            dateBirth.ValueChanged += dateBirth_ValueChanged;
            // 
            // languageList
            // 
            languageList.FormattingEnabled = true;
            languageList.ItemHeight = 25;
            languageList.Items.AddRange(new object[] { "Монгол", "Англи", "Орос", "Хятад", "Япон", "Солонгос" });
            languageList.Location = new Point(231, 76);
            languageList.Name = "languageList";
            languageList.Size = new Size(140, 154);
            languageList.TabIndex = 6;
            languageList.SelectedIndexChanged += languageList_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(231, 280);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(409, 280);
            treeView1.Name = "treeView1";
            treeNode13.Name = "";
            treeNode13.Text = "Мэдээллийн технологи";
            treeNode14.Name = "";
            treeNode14.Text = "Програм хангамж";
            treeNode15.Name = "";
            treeNode15.Text = "Компьютерын ухаан";
            treeNode16.Name = "";
            treeNode16.Text = "Математик";
            treeNode17.Name = "";
            treeNode17.Text = "Физик";
            treeNode18.Name = "";
            treeNode18.Text = "Байгалийн ухааны сургууль";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode15, treeNode18 });
            treeView1.Size = new Size(310, 192);
            treeView1.TabIndex = 15;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(240, 493);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(489, 191);
            richTextBox1.TabIndex = 16;
            richTextBox1.Text = "Hac: 19\nТөрсөн өдөр: 2006-12-01\nСургалт: Өдрийн\nТэнхим: Мэдээллийн технологи\nТэтгэлэг: Тийм\nХичээл: Программчлал, Өгегдлийн бутэц\nХэл: Англи\n";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(24, 593);
            button1.Name = "button1";
            button1.Size = new Size(180, 55);
            button1.TabIndex = 17;
            button1.Text = "Бүртгэх";
            button1.Click += button1_Click;
            // 
            // labelPicture
            // 
            labelPicture.AutoSize = true;
            labelPicture.Location = new Point(231, 250);
            labelPicture.Name = "labelPicture";
            labelPicture.Size = new Size(103, 25);
            labelPicture.TabIndex = 12;
            labelPicture.Text = "Цээж зураг";
            // 
            // labelProgress
            // 
            labelProgress.AutoSize = true;
            labelProgress.Location = new Point(37, 724);
            labelProgress.Name = "labelProgress";
            labelProgress.Size = new Size(138, 25);
            labelProgress.TabIndex = 18;
            labelProgress.Text = "Бүртгэлийн явц";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(37, 752);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(692, 30);
            progressBar1.TabIndex = 19;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(416, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(332, 181);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Овог нэр ";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ToolTipText = "Х.Уянга";
            Column1.Width = 90;
            // 
            // Column2
            // 
            Column2.HeaderText = "Утас";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ToolTipText = "93011201";
            Column2.Width = 90;
            // 
            // Column3
            // 
            Column3.HeaderText = "Нас";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 80;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(760, 794);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(checkBox1);
            Controls.Add(radioButton1);
            Controls.Add(checkedListBox1);
            Controls.Add(languageList);
            Controls.Add(numericAge);
            Controls.Add(comboDepartment);
            Controls.Add(maskedPhone);
            Controls.Add(dateBirth);
            Controls.Add(labelPicture);
            Controls.Add(pictureBox1);
            Controls.Add(treeView1);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(labelProgress);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Оюутны бүртгэлийн программ";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}
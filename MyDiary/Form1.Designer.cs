namespace MyDiary
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.dayMoneyGridView = new System.Windows.Forms.DataGridView();
            this.dateTextBox1 = new System.Windows.Forms.TextBox();
            this.diaryEditTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DiarySaveButton = new System.Windows.Forms.Button();
            this.monthDiaryGridView = new System.Windows.Forms.DataGridView();
            this.dateTextBox2 = new System.Windows.Forms.TextBox();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.moneyAddButton = new System.Windows.Forms.Button();
            this.itemPriceTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dayMoneySumTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataSet = new MyDiary.DataSet1();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全データを閲覧ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日記ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.家計簿ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.元に戻すUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.やり直しRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.切り取りTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.コピーCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.貼り付けPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ツールTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.オプションOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.使い方SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.monthMoneyGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.monthMoneySumTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dayMoneyGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthDiaryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthMoneyGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(181, 31);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 1;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.OnDateChanged);
            // 
            // dayMoneyGridView
            // 
            this.dayMoneyGridView.AllowUserToAddRows = false;
            this.dayMoneyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dayMoneyGridView.Location = new System.Drawing.Point(290, 242);
            this.dayMoneyGridView.Name = "dayMoneyGridView";
            this.dayMoneyGridView.RowTemplate.Height = 21;
            this.dayMoneyGridView.Size = new System.Drawing.Size(311, 161);
            this.dayMoneyGridView.TabIndex = 5;
            this.dayMoneyGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.OnMoneyDeleting);
            // 
            // dateTextBox1
            // 
            this.dateTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.dateTextBox1.Location = new System.Drawing.Point(18, 242);
            this.dateTextBox1.Name = "dateTextBox1";
            this.dateTextBox1.ReadOnly = true;
            this.dateTextBox1.Size = new System.Drawing.Size(150, 19);
            this.dateTextBox1.TabIndex = 2;
            // 
            // diaryEditTextBox
            // 
            this.diaryEditTextBox.Location = new System.Drawing.Point(18, 266);
            this.diaryEditTextBox.Multiline = true;
            this.diaryEditTextBox.Name = "diaryEditTextBox";
            this.diaryEditTextBox.Size = new System.Drawing.Size(252, 183);
            this.diaryEditTextBox.TabIndex = 3;
            this.diaryEditTextBox.TextChanged += new System.EventHandler(this.OnDiaryEditTextChangerd);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "日記";
            // 
            // DiarySaveButton
            // 
            this.DiarySaveButton.Location = new System.Drawing.Point(108, 473);
            this.DiarySaveButton.Name = "DiarySaveButton";
            this.DiarySaveButton.Size = new System.Drawing.Size(84, 27);
            this.DiarySaveButton.TabIndex = 4;
            this.DiarySaveButton.Text = "保存";
            this.DiarySaveButton.UseVisualStyleBackColor = true;
            this.DiarySaveButton.Click += new System.EventHandler(this.OnDiarySaveButtonClicked);
            // 
            // monthDiaryGridView
            // 
            this.monthDiaryGridView.AllowUserToAddRows = false;
            this.monthDiaryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monthDiaryGridView.Location = new System.Drawing.Point(662, 331);
            this.monthDiaryGridView.Name = "monthDiaryGridView";
            this.monthDiaryGridView.ReadOnly = true;
            this.monthDiaryGridView.RowTemplate.Height = 21;
            this.monthDiaryGridView.Size = new System.Drawing.Size(365, 194);
            this.monthDiaryGridView.TabIndex = 13;
            this.monthDiaryGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.OnDiaryDeleting);
            // 
            // dateTextBox2
            // 
            this.dateTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.dateTextBox2.Location = new System.Drawing.Point(290, 473);
            this.dateTextBox2.Name = "dateTextBox2";
            this.dateTextBox2.ReadOnly = true;
            this.dateTextBox2.Size = new System.Drawing.Size(90, 19);
            this.dateTextBox2.TabIndex = 7;
            // 
            // itemTextBox
            // 
            this.itemTextBox.Location = new System.Drawing.Point(386, 473);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.Size = new System.Drawing.Size(101, 19);
            this.itemTextBox.TabIndex = 8;
            this.itemTextBox.TextChanged += new System.EventHandler(this.OnItemTextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "日付";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "用途";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "金額";
            // 
            // moneyAddButton
            // 
            this.moneyAddButton.Location = new System.Drawing.Point(503, 498);
            this.moneyAddButton.Name = "moneyAddButton";
            this.moneyAddButton.Size = new System.Drawing.Size(98, 27);
            this.moneyAddButton.TabIndex = 10;
            this.moneyAddButton.Text = "追加";
            this.moneyAddButton.UseVisualStyleBackColor = true;
            this.moneyAddButton.Click += new System.EventHandler(this.OnMoneyAddButtonClicked);
            // 
            // itemPriceTextBox
            // 
            this.itemPriceTextBox.Location = new System.Drawing.Point(494, 473);
            this.itemPriceTextBox.Mask = "99999";
            this.itemPriceTextBox.Name = "itemPriceTextBox";
            this.itemPriceTextBox.Size = new System.Drawing.Size(107, 19);
            this.itemPriceTextBox.TabIndex = 9;
            this.itemPriceTextBox.ValidatingType = typeof(int);
            this.itemPriceTextBox.TextChanged += new System.EventHandler(this.OnItemPriceTextChanged);
            // 
            // dayMoneySumTextBox
            // 
            this.dayMoneySumTextBox.Location = new System.Drawing.Point(458, 409);
            this.dayMoneySumTextBox.Name = "dayMoneySumTextBox";
            this.dayMoneySumTextBox.Size = new System.Drawing.Size(143, 19);
            this.dayMoneySumTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "支出合計";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.編集EToolStripMenuItem,
            this.ツールTToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1069, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全データを閲覧ToolStripMenuItem,
            this.toolStripSeparator1,
            this.終了XToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 全データを閲覧ToolStripMenuItem
            // 
            this.全データを閲覧ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.日記ToolStripMenuItem,
            this.家計簿ToolStripMenuItem});
            this.全データを閲覧ToolStripMenuItem.Name = "全データを閲覧ToolStripMenuItem";
            this.全データを閲覧ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.全データを閲覧ToolStripMenuItem.Text = "全データを閲覧...";
            // 
            // 日記ToolStripMenuItem
            // 
            this.日記ToolStripMenuItem.Name = "日記ToolStripMenuItem";
            this.日記ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.日記ToolStripMenuItem.Text = "日記データ";
            this.日記ToolStripMenuItem.Click += new System.EventHandler(this.日記ToolStripMenuItem_Click);
            // 
            // 家計簿ToolStripMenuItem
            // 
            this.家計簿ToolStripMenuItem.Name = "家計簿ToolStripMenuItem";
            this.家計簿ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.家計簿ToolStripMenuItem.Text = "家計簿データ";
            this.家計簿ToolStripMenuItem.Click += new System.EventHandler(this.家計簿ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // 終了XToolStripMenuItem
            // 
            this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
            this.終了XToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.終了XToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.終了XToolStripMenuItem.Text = "終了(&X)";
            this.終了XToolStripMenuItem.Click += new System.EventHandler(this.終了XToolStripMenuItem_Click);
            // 
            // 編集EToolStripMenuItem
            // 
            this.編集EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.元に戻すUToolStripMenuItem,
            this.やり直しRToolStripMenuItem,
            this.toolStripSeparator3,
            this.切り取りTToolStripMenuItem,
            this.コピーCToolStripMenuItem,
            this.貼り付けPToolStripMenuItem});
            this.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
            this.編集EToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.編集EToolStripMenuItem.Text = "編集(&E)";
            // 
            // 元に戻すUToolStripMenuItem
            // 
            this.元に戻すUToolStripMenuItem.Name = "元に戻すUToolStripMenuItem";
            this.元に戻すUToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.元に戻すUToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.元に戻すUToolStripMenuItem.Text = "元に戻す(&U)";
            this.元に戻すUToolStripMenuItem.Click += new System.EventHandler(this.元に戻すUToolStripMenuItem_Click);
            // 
            // やり直しRToolStripMenuItem
            // 
            this.やり直しRToolStripMenuItem.Name = "やり直しRToolStripMenuItem";
            this.やり直しRToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.やり直しRToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.やり直しRToolStripMenuItem.Text = "やり直し(&R)";
            this.やり直しRToolStripMenuItem.Click += new System.EventHandler(this.やり直しRToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(170, 6);
            // 
            // 切り取りTToolStripMenuItem
            // 
            this.切り取りTToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("切り取りTToolStripMenuItem.Image")));
            this.切り取りTToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.切り取りTToolStripMenuItem.Name = "切り取りTToolStripMenuItem";
            this.切り取りTToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.切り取りTToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.切り取りTToolStripMenuItem.Text = "切り取り(&T)";
            this.切り取りTToolStripMenuItem.Click += new System.EventHandler(this.切り取りTToolStripMenuItem_Click);
            // 
            // コピーCToolStripMenuItem
            // 
            this.コピーCToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("コピーCToolStripMenuItem.Image")));
            this.コピーCToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.コピーCToolStripMenuItem.Name = "コピーCToolStripMenuItem";
            this.コピーCToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.コピーCToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.コピーCToolStripMenuItem.Text = "コピー(&C)";
            this.コピーCToolStripMenuItem.Click += new System.EventHandler(this.コピーCToolStripMenuItem_Click);
            // 
            // 貼り付けPToolStripMenuItem
            // 
            this.貼り付けPToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("貼り付けPToolStripMenuItem.Image")));
            this.貼り付けPToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.貼り付けPToolStripMenuItem.Name = "貼り付けPToolStripMenuItem";
            this.貼り付けPToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.貼り付けPToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.貼り付けPToolStripMenuItem.Text = "貼り付け(&P)";
            this.貼り付けPToolStripMenuItem.Click += new System.EventHandler(this.貼り付けPToolStripMenuItem_Click);
            // 
            // ツールTToolStripMenuItem
            // 
            this.ツールTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.オプションOToolStripMenuItem});
            this.ツールTToolStripMenuItem.Name = "ツールTToolStripMenuItem";
            this.ツールTToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ツールTToolStripMenuItem.Text = "ツール(&T)";
            // 
            // オプションOToolStripMenuItem
            // 
            this.オプションOToolStripMenuItem.Name = "オプションOToolStripMenuItem";
            this.オプションOToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.オプションOToolStripMenuItem.Text = "オプション(&O)";
            this.オプションOToolStripMenuItem.Click += new System.EventHandler(this.オプションOToolStripMenuItem_Click);
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.使い方SToolStripMenuItem});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // 使い方SToolStripMenuItem
            // 
            this.使い方SToolStripMenuItem.Name = "使い方SToolStripMenuItem";
            this.使い方SToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.使い方SToolStripMenuItem.Text = "使い方";
            this.使い方SToolStripMenuItem.Click += new System.EventHandler(this.使い方SToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "家計簿";
            // 
            // monthMoneyGridView
            // 
            this.monthMoneyGridView.AllowUserToAddRows = false;
            this.monthMoneyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monthMoneyGridView.Location = new System.Drawing.Point(662, 83);
            this.monthMoneyGridView.Name = "monthMoneyGridView";
            this.monthMoneyGridView.RowTemplate.Height = 21;
            this.monthMoneyGridView.Size = new System.Drawing.Size(365, 208);
            this.monthMoneyGridView.TabIndex = 11;
            this.monthMoneyGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.OnMoneyDeleting);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(804, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "支出合計";
            // 
            // monthMoneySumTextBox
            // 
            this.monthMoneySumTextBox.Location = new System.Drawing.Point(884, 297);
            this.monthMoneySumTextBox.Name = "monthMoneySumTextBox";
            this.monthMoneySumTextBox.Size = new System.Drawing.Size(143, 19);
            this.monthMoneySumTextBox.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(622, 511);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox2.Location = new System.Drawing.Point(622, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(447, 511);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(659, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "○月";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 537);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.monthMoneySumTextBox);
            this.Controls.Add(this.monthMoneyGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dayMoneySumTextBox);
            this.Controls.Add(this.itemPriceTextBox);
            this.Controls.Add(this.moneyAddButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemTextBox);
            this.Controls.Add(this.dateTextBox2);
            this.Controls.Add(this.monthDiaryGridView);
            this.Controls.Add(this.DiarySaveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diaryEditTextBox);
            this.Controls.Add(this.dateTextBox1);
            this.Controls.Add(this.dayMoneyGridView);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dayMoneyGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthDiaryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthMoneyGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.DataGridView dayMoneyGridView;
        private DataSet1 dataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataColumn1DataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox dateTextBox1;
        private System.Windows.Forms.TextBox diaryEditTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DiarySaveButton;
        private System.Windows.Forms.DataGridView monthDiaryGridView;
        private System.Windows.Forms.TextBox dateTextBox2;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button moneyAddButton;
        private System.Windows.Forms.MaskedTextBox itemPriceTextBox;
        private System.Windows.Forms.TextBox dayMoneySumTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編集EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 元に戻すUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem やり直しRToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 切り取りTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem コピーCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 貼り付けPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ツールTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem オプションOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 使い方SToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView monthMoneyGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox monthMoneySumTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem 全データを閲覧ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日記ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 家計簿ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}


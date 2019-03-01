using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MyDiary
{
    public partial class Form1 : Form
    {
        Form1Service f1service = new Form1Service();

        public Form1()
        {
            InitializeComponent();

            //カレンダーで複数日選択できないようにする
            monthCalendar.MaxSelectionCount = 1;

            SetFormData();
            f1service.GetFormData();
            f1service.Start();
            GetFormData();

        }

        void SetFormData()
        {
            Form1Data.dataSet = dataSet;
            Form1Data.monthDiaryGridView = monthDiaryGridView;
            Form1Data.dayMoneyGridView = dayMoneyGridView;
            Form1Data.monthMoneyGridView = monthMoneyGridView;
            Form1Data.monthCalendar = monthCalendar;
        }

        void GetFormData()
        {
            dayMoneySumTextBox.Text = Form1Data.dayMoneySumTextBoxText;
            monthMoneySumTextBox.Text = Form1Data.monthMoneySumTextBoxText;
            dateTextBox1.Text = Form1Data.date;
            dateTextBox2.Text = Form1Data.date;
            diaryEditTextBox.Text = Form1Data.diaryEditTextBoxText;
            itemTextBox.Text = Form1Data.itemTextBoxText;
            itemPriceTextBox.Text = Form1Data.itemPriceTextBoxText;
        }

        //カレンダーで選択された日付が変更された際に呼び出されるメソッド
        private void OnDateChanged(object sender, DateRangeEventArgs e)
        {
            f1service.OnDateChanged();

            GetFormData();
        }

        //日記を保存するボタンが押された際に呼ばれるメソッド
        private void OnDiarySaveButtonClicked(object sender, EventArgs e)
        {
            f1service.OnDiarySaveButtonClicked();
        }

        //支出を追加するボタンが押された際に呼ばれるメソッド
        private void OnMoneyAddButtonClicked(object sender, EventArgs e)
        {
            f1service.OnMoneyAddButtonClicked();
            dayMoneySumTextBox.Text = Form1Data.dayMoneySumTextBoxText;
        }

        private void OnDiaryDeleting(object sender, DataGridViewRowCancelEventArgs e)
        {
            f1service.OnDiaryDeleting(sender, e);
        }

        private void OnMoneyDeleting(object sender, DataGridViewRowCancelEventArgs e)
        {
            f1service.OnMoneyDeleting(sender, e);
            dayMoneySumTextBox.Text = Form1Data.dayMoneySumTextBoxText;
        }

        private void OnDiaryEditTextChangerd(object sender, EventArgs e)
        {
            Form1Data.diaryEditTextBoxText = diaryEditTextBox.Text;
        }

        private void OnItemTextChanged(object sender, EventArgs e)
        {
            Form1Data.itemTextBoxText = itemTextBox.Text;
        }

        private void OnItemPriceTextChanged(object sender, EventArgs e)
        {
            Form1Data.itemPriceTextBoxText = itemPriceTextBox.Text;
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 日記ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(Form1Data.dataSet.diaryDataTable);
            form2.Show();
        }

        private void 家計簿ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(Form1Data.dataSet.moneyDataTable);
            form2.Show();
        }

        private void 元に戻すUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void やり直しRToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 切り取りTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void コピーCToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 貼り付けPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void オプションOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 使い方SToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

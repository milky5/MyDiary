using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace MyDiary
{

    public class Form1Service
    {
        string monthlyDate;
        string fileName = @"..\..\datafile.xml";

        DataSet1 dataSet;
        DataGridView dayMoneyGridView;
        DataGridView monthMoneyGridView;
        DataGridView monthDiaryGridView;
        MonthCalendar monthCalendar;

        public void GetFormData()
        {
            dataSet = Form1Data.dataSet;
            monthDiaryGridView = Form1Data.monthDiaryGridView;
            dayMoneyGridView = Form1Data.dayMoneyGridView;
            monthMoneyGridView = Form1Data.monthMoneyGridView;
            monthCalendar = Form1Data.monthCalendar;
        }

        public void Start()
        {
            
            if (System.IO.File.Exists(fileName))
            {
                dataSet.ReadXml(fileName);
            }

            //今日の日付を yyyy/mm/dd の形式で保持
            Form1Data.date = DateTime.Today.ToShortDateString();

            //選択された日付の日記を探すメソッドを呼び出す
            FindDiary();
            FindMoneyData();

            //支出合計を TextBox に表示させる
            //以下、全データの合計を取得
            //Form1Data.moneySumTextBoxText = moneyDataTable.Compute("Sum(金額)", null).ToString();

            FindMonthMoneyData();
            FindMonthDiary();
        }

        //選択された日付の日記を探すメソッド
        public void FindDiary()
        {
            //2箇所のdateTextBoxに表示するメソッドを呼び出す
            SetDate();

            Form1Data.diaryEditTextBoxText = null;

            //選択された日付の日記を探す
            var row = dataSet.diaryDataTable.Rows.Find(Form1Data.date);
            var colum = dataSet.diaryDataTable.Columns.IndexOf("日記");

            //選択された日付の日記が存在しなければ return
            if (row == null) return;

            //選択された日付の日記が存在していれば、内容を TextBox に代入
            var value = DataRowExtensions.Field<string>(row, colum);
            Form1Data.diaryEditTextBoxText = value;
        }

        //選択された日付の家計簿を探すメソッド
        public void FindMoneyData()
        {
            DataRow[] dRows = dataSet.moneyDataTable.AsEnumerable()
              .Where(row => row.Field<string>("日付").Contains(Form1Data.date)).ToArray();
            dataSet.dayMoneyDataTable.Clear();
            foreach (var row in dRows)
            {
                dataSet.dayMoneyDataTable.Rows.Add(row[0].ToString(), row[1].ToString(), Convert.ToInt32(row[2]));
            }
            dayMoneyGridView.DataSource = dataSet;
            dayMoneyGridView.DataMember = "dayMoneyDataTable";
            Form1Data.dayMoneySumTextBoxText = dataSet.dayMoneyDataTable.Compute("Sum(金額)", null).ToString();
        }

        //選択された月の日記を探すメソッド
        void FindMonthDiary()
        {
            DataRow[] dRows = dataSet.diaryDataTable.AsEnumerable()
                .Where(row => row.Field<string>("日付").Contains(monthlyDate)).ToArray();
            dataSet.monthDiaryDataTable.Clear();
            foreach (var row in dRows)
            {
                dataSet.monthDiaryDataTable.Rows.Add(row[0].ToString(), row[1].ToString());
            }
            monthDiaryGridView.DataSource = dataSet;
            monthDiaryGridView.DataMember = "monthDiaryDataTable";
        }

        //選択された月の家計簿を探すメソッド
        void FindMonthMoneyData()
        {
            DataRow[] dRows = dataSet.moneyDataTable.AsEnumerable()
                .Where(row => row.Field<string>("日付").Contains(monthlyDate)).ToArray();
            dataSet.monthMoneyDataTable.Clear();
            foreach (var row in dRows)
            {
                dataSet.monthMoneyDataTable.Rows.Add(row[0].ToString(), row[1].ToString(), Convert.ToInt32(row[2]));
            }
            monthMoneyGridView.DataSource = dataSet;
            monthMoneyGridView.DataMember = "monthMoneyDataTable";
            Form1Data.monthMoneySumTextBoxText = dataSet.monthMoneyDataTable.Compute("Sum(金額)", null).ToString();
        }

        //選択中の日付を選択中の月に変換させるためのメソッド
        public void SetDate()
        {
            var dates = Form1Data.date.Split('/');
            monthlyDate = dates[0] + "/" + dates[1];
        }

        //カレンダーで選択された日付が変更された際に呼び出されるメソッド
        public void OnDateChanged()
        {
            //カレンダーで新たに選択された日付を yyyy/mm/dd の形式で保持
            Form1Data.date = monthCalendar.SelectionStart.ToShortDateString();

            //選択された日付の日記を探すメソッドを呼び出す
            FindDiary();
            FindMoneyData();

            FindMonthMoneyData();
            FindMonthDiary();
        }

        //日記を保存するボタンが押された際に呼ばれるメソッド
        public void OnDiarySaveButtonClicked()
        {
            //選択された日付の日記を探す
            var row = dataSet.diaryDataTable.Rows.Find(Form1Data.date);
            var colum = dataSet.diaryDataTable.Columns.IndexOf("日記");
            if (row != null)
            {
                dataSet.diaryDataTable.Rows.Remove(row);
            }
            dataSet.diaryDataTable.Rows.Add(Form1Data.date, Form1Data.diaryEditTextBoxText);
            dataSet.WriteXml(fileName);
            FindMonthDiary();
        }

        //支出を追加するボタンが押された際に呼ばれるメソッド
        public void OnMoneyAddButtonClicked()
        {
            dataSet.moneyDataTable.Rows.Add(Form1Data.date, Form1Data.itemTextBoxText, int.Parse(Form1Data.itemPriceTextBoxText));
            dataSet.WriteXml(fileName);
            Form1Data.dayMoneySumTextBoxText = dataSet.moneyDataTable.Compute("Sum(金額)", null).ToString();
            FindMonthMoneyData();
        }

        public void OnDiaryDeleting(object sender, DataGridViewRowCancelEventArgs e)
        {
            var result = AskDelete();
            if (result)
            {
                dataSet.WriteXml(fileName);
            }
            else
            {
                e.Cancel = true;
            }
        }

        public void OnMoneyDeleting(object sender, DataGridViewRowCancelEventArgs e)
        {
            var result = AskDelete();
            if (result)
            {
                dataSet.WriteXml(fileName);
                Form1Data.dayMoneySumTextBoxText = dataSet.moneyDataTable.Compute("Sum(金額)", null).ToString();
            }
            else
            {
                e.Cancel = true;
            }
        }

        bool AskDelete()
        {
            DialogResult result = MessageBox.Show(
                "このデータを削除しますか？",
                "確認",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
                return true;
            return false;
        }
    }
}
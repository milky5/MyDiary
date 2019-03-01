using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace MyDiary
{
    static class Form1Data
    {
        //今のところ渡すしかないもの
        public static DataSet1 dataSet { get; set; }
        public static DataGridView monthDiaryGridView { get; set; }
        public static DataGridView dayMoneyGridView { get; set; }
        public static DataGridView monthMoneyGridView { get; set; }
        public static MonthCalendar monthCalendar { get; set; }

        //string型に変換すればいいもの(仕様仮確定)
        public static string dayMoneySumTextBoxText { get; set; }
        public static string monthMoneySumTextBoxText { get; set; }
        public static string date { get; set; }
        public static string diaryEditTextBoxText { get; set; }
        public static string itemTextBoxText { get; set; }
        public static string itemPriceTextBoxText { get; set; }
    }
}

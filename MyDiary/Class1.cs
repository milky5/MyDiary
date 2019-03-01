using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace MyDiary
{
    class Class1
    {
        DataGridView dataGridView;
        DataSet1 dataSet;

        void Set()
        {
            Class2.dataGridView = dataGridView;
            Class2.dataSet = dataSet;
            Class2.dataTable = dataSet.moneyDataTable;
        }
    }

    static class Class2
    {
        public static DataGridView dataGridView { get; set; }
        public static DataSet1 dataSet { get; set; }
        public static DataTable dataTable { get; set; }
    }

    class Class3
    {
        DataGridView dataGridView;
        DataSet1 dataSet;
        DataTable moneyDataTable;

        void Get()
        {
            dataGridView = Class2.dataGridView;
            dataSet = Class2.dataSet;
            moneyDataTable = Class2.dataTable;
        }

        /// <summary>
        /// ここがメイン。
        /// なぜか、他のDataGridViewに表示されてしまう。
        /// </summary>
        void Main()
        {
            dataGridView.DataSource = dataSet;
            dataGridView.DataMember = "moneyDataTable";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDiary
{
    public partial class Form4 : Form
    {
        Option option;
        Form1 form1;

        public Form4(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void OnRightClolorChange(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            //option.rightColor = colorDialog1.Color;
        }

        private void OnLeftColorChange(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            //option.leftColor = colorDialog1.Color;
        }

        private void OnOKButonClicked(object sender, EventArgs e)
        {
            
        }
    }
}

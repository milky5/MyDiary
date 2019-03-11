using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiary
{
    // DesignPattern Singleton
    public class Option
    {
        static Option option { get; set; }
        public Color rightColor{ get; set; }
        public Color leftColor { get; set; }

        private Option()
        {
        }

        public Option GetInstance()
        {
            if (option == null)
            {
                option = new Option();
            }
            return option;
        }

    }
}

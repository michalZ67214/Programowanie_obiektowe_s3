using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Data
    {
        private DateTime data;

        public Data(DateTime data)
        {
            this.data = data;
        }

        public string getCurrentDate() 
        {
            return this.data.ToString("dd.MM.yyyy");
        }

        public void PlusOneDay()
        {
            this.data = this.data.AddDays(1);
        }

        public void MinusOneDay()
        {
            this.data = this.data.AddDays(-1);
        }
    }
}

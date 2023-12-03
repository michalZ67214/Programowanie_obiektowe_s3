using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania
{
    internal class Student : Person
    {
        public string School {  get; set; }

        public bool MozeSamWracacDoDomu {  get; set; }

        public void SetSchool(string school)
        {
            this.School = school;
        }

        public void ChangeSchool(string school)
        {
            this.School = school;
        }

        public void SetCanGoHomeAlone(bool can)
        {
            this.MozeSamWracacDoDomu = can;
        }

        public override string GetEducationInfo()
        {
            return $"Edukacja: {this.School}";
        }

        public override bool CanGoAloneToHome()
        {
            return this.GetAge() > 12 || this.MozeSamWracacDoDomu;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_UniversityEmployee.Classes
{
    public class UniversityEmployee
    {
        public Person Person { get; set; }
        private int _taxId;
        public int TaxId 
        {
            get
            {
                return _taxId;
            }
            set
            {
                if (value > 0)
                {
                    _taxId = value;
                }
            }
        }
        
        public UniversityEmployee(Person person, int taxId)
        {
            Person = person;
            TaxId = taxId;
        }

        public virtual string GetOfficialDuties()
        {
            return Person.Name + " " + Person.LastName + 
                ". This person is ";
        }
    }
}

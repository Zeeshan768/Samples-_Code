using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Sample_44
    {
    public class StaffMember
        {
        private int ageValue;
        public int Age
            {
            set
                {
                if((value>0)&&(value < 120))
                    {
                    this.ageValue = value;
                    }
                }
            get
                {
                return this.ageValue;
                }
            }
        }
   public  class StaffDemo
        {
        static void Main()
            {
            StaffMember s = new StaffMember();
            s.Age = 21;
            Console.WriteLine("Age is : " + s.Age);
            Console.ReadKey();
            }
        }
    }

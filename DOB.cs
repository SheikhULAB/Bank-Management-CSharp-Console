using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{

    class DOB
    {
        
        public int day;
        private int month;
        private int year;
       
        public void Set(int d, int m, int y)
        {

            this.day = d;
            this.month = m;
            this.year = y;


        }
        public bool CheckDate()
        {
            if (day > 31 || month > 12 || year > 2005)
            {
                Console.WriteLine("Wrong date is given ");
                return false;

            }
            else
                return true;

        }
        public bool PrintDate()
        {


            if (CheckDate() == true)
            {
                Console.WriteLine("Date is : " + day + "-" + month + "-" + year);
                return false;
            }
            else
                Console.WriteLine("Enter your date again");
            return true;


        }
    }
}
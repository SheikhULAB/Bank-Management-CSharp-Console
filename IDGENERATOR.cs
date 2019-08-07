using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class IDGENERATOR
    {
       
        static int id = 0;
        string stockID;
        DateTime date = DateTime.Now;

        public string generateID()
        {
            string createID = DateTime.Now.ToString("YYYY-MM-DD");
            stockID = createID + ++id;
           
            return stockID;

        }

    }
}
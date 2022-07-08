using System;
using System.Collections.Generic;
using System.Linq;





//this changs by akshay

namespace FirstApp
{
    internal class Class2
    {
       
        public static int count;

        // data members
        private string fName;
        private string lName;
        private DateTime bDate;
        private string cNumber;
        private string email;

       
       
        public Class2()
        {
            count++;
        }
        public Class2(string fName, string lName, DateTime bDate, string contact, string email)
        {
            this.fName = fName;
            this.lName = lName;
            this.bDate = bDate;
            this.cNumber = contact;
            this.email = email;
            count++;
        }


        public static int GetCount()
        {
            return count;
        }
        ~Class2()
        {
          

        }

        public override string ToString()
        {
            return base.ToString() + " : " + this.fName + " " +
                this.lName + " " + this.bDate + " " +
                this.cNumber + " " + this.email+count;
        }
    }
}

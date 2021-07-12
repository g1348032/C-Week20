using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Takuya Hasama, 30038637, 15.06.2021, Assessment Task 2
// a stand-alone application which will be used 
// in-house to keep track of all books and sales. 
namespace AT2Project
{
    class Customer
    {

        //A Customer class which has attributes custID, name, location, email., 
        //They must be private, with associated assessor methods to store and retrieve information.

        private string custId;
        private string fullName;
        private string city;
        private string email;

        //Methods for accessing the value of the attributes
        public string gsCustId
        {
            get { return custId; }
            set { custId = value; }
        }

        public string gsFullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string gsCity
        {
            get { return city; }
            set { city = value; }
        }

        public string gsEmail
        {
            get { return email; }
            set { email = value; }
        }
        //Cutom method to display a customer
        public string DisplayCustomerDetails()
        {
            return gsCustId + "-" + gsFullName + "-" + gsCity + "-" + gsEmail;
        }

        //Custom method for binary file
        public string saveCustomers()
        {
            return gsCustId + "," + gsFullName + "," + gsCity + "," + gsEmail;
        }

    }
}


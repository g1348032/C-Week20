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
    class Book
    {
        //A Book class which has attributes isbn, author, title, publisher, price and date, 
        //They must be private, with associated assessor methods to store and retrieve information.

        private string isbn;
        private string author;
        private string title;
        private string publisher;
        private double price;
        private string date;

        //Methods for accessing the value of the attributes

        public string gsIsbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string gsAuthor
        {
            get { return author; }
            set { author = value; }
        }
        
        public string gsTitle
        {
            get { return title; }
            set { title = value; }
        }

        public string gsPublisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        public double gsPrice
        {
            get { return price; }
            set { price = value; }
        }

        public string gsDate
        {
            get { return date; }
            set { date = value; }
        }

        
        //Cutom method to display a book
        public string DisplayBookDetails()
        {
            return gsIsbn + "-" + gsAuthor + "-" + gsTitle;
        }
        //Custom method for binary file
        public string saveBooks()
        {
            return gsIsbn + "," + gsAuthor + "," + gsTitle + "," + gsPublisher + "," + gsPrice + "," + gsDate;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Book
    {
        string name;
        int year;
        double price;
        Author author;
        
        public Book(string name, int year, double price, Author author)
        {
            this.name = name;
            this.year = year;
            this.price = price;
            this.author= author;   
        }

        public string GetName()
        {
            return name;
        }
        public string GetAuthor()
        {
            return author.GetName();
        }

        public double GetPrice()
        {
            return price;
        }
        public int GetYear()
        {
            return year;
        }
        
    }
}

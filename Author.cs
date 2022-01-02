using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Author
    {
        string name;
        string email;
        public Author(string name, string email)
        {
            this.name = name;
            this.email = email;
        }

        public Author(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }

        public string GetEmail()
        {
            return email;
        }

      
    }
}

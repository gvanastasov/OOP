using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Inheritance.BookShop
{
    public class Book
    {
        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        protected string title;
        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                if(value.Length < 3)
                {
                    throw new Exception("Title not valid!");
                }

                this.title = value;
            }
        }

        protected string author;
        public string Author
        {
            get
            {
                return this.author;
            }
            set
            {
                var tokens = value.Split(' ');
                var secondName = tokens[1];

                if (Regex.IsMatch(secondName[0].ToString(), @"^\d$"))
                {
                    throw new Exception("Author not valid!");
                }

                this.author = value;
            }
        }

        protected decimal price;
        public virtual decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Price not valid!");
                }

                this.price = Math.Round(value, 1);
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Type: ").AppendLine(this.GetType().Name)
                .Append("Title: ").AppendLine(this.Title)
                .Append("Author: ").AppendLine(this.Author)
                .Append("Price: ").Append($"{this.Price:f1}")
                .AppendLine();

            return sb.ToString();
        }
    }
}

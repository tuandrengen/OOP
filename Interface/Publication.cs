using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Publication : IListable
    {
        public string title { get; set; }
        public string author { get; set; }
        public int year { get; set; }
        public Publication(string title, string author, int year)
        {
            this.title = title;
            this.author = author;
            this.year = year;
        }
        public string[] ColumnValues
        {
            get
            {
                return new string[] { title, author, year.ToString() };
            }
        }
        public static string[] Headers
        {
            get
            {
                return new string[] { "Title", "Author", "Year" };
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Library
    {
        public Library()
        {

        }
        public Library(string bookname, string author, int pagecount)
        {
            _bookname = bookname;
            _author = author;
            _pagecount = pagecount;
        }

        public string _bookname { get; }
        public string _author { get; }
        public int _pagecount { get; }
        private void Print(List<Library> library)
        {
            for (int i = 0; i < library.Count; i++)
            {
                Console.WriteLine($"bookname - {library[i]._bookname}\n author - {library[i]._author}\n pagecount - {library[i]._pagecount} ");
            }
        }
        public static bool TryGetAuthor(List<Library> library, string name)
        {

            bool hasauthor = false;

            for (int i = 0; i < library.Count; i++)
            {
                if (library[i]._author == name)
                {
                    name = library[i]._author;
                    hasauthor = true;
                    break;
                }
            }
            return hasauthor;
        }
        public static bool TryGetBookName(List<Library> library, string name)
        {

            bool hasbook = false;

            for (int i = 0; i < library.Count; i++)
            {
                if (library[i]._bookname == name)
                {
                    name = library[i]._bookname;
                    hasbook = true;
                    break;
                }
            }
            return hasbook;
        }
    }
}

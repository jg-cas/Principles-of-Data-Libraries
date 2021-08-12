using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace BookLibrary
{
    public enum PlatformChoices {[Description("Hard Cover")] HardCover, EBook } //tried this but didn't work
    public enum AvailabilityChoices { Available, [Description("Not Available")] NotAvailable }
    public class Book : ICRUD
    {
        public List<BookData> BookCollection;
        public Book()
        {
            BookCollection = new List<BookData>();
        }
        public void create(BookData obj)
        {
            BookCollection.Add(obj);
        }

        public bool Delete(double ISBN)
        {
            var collection = BookCollection.ToDictionary(book => book.ISBN);
            BookData found;
            if (collection.TryGetValue(ISBN, out found))
            {
                BookCollection.Remove(found);
                return true;
            }
            else
            {
                return false;
            }
        }

        public ICollection<BookData> Read()
        {
            return BookCollection;
        }

        public bool Update(BookData obj, double ISBN)
        {
            var collection = BookCollection.ToDictionary(book => book.ISBN);
            BookData found;
            if (collection.TryGetValue(ISBN, out found))
            {
                found.Availability = obj.Availability;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

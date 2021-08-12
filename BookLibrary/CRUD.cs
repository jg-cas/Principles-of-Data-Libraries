using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    interface ICRUD
    {
        void create(BookData obj);
        ICollection<BookData> Read();
        bool Update(BookData obj, double ISBN);
        bool Delete(double ISBN);
    }
}

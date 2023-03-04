using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.Entity.Concrete
{
    public class Destination
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Desciption { get; set; }
        public int Capacity { get; set; }
        public bool Status { get; set; }
    }
}

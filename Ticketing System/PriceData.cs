using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recreation_Center_Ticketing_Method
{
    class PriceData
    {
        public int GroupCount { get; set; }
        public int Duration { get; set; }
        public int weekendChildPrice { get; set; }
        public int weekDaysChild { get; set; }
        public int weekendAdultPrice { get; set; }
        public int weekDaysAdult { get; set; }
        public int weekendAgedPrice { get; set; }
        public int weekDaysAged { get; set; }
    }

}

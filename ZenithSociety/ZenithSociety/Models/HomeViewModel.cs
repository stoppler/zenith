using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZenithDataLib.Models;

namespace ZenithSociety.Models
{
    public class HomeViewModel
    {
        public List<Event> Mon { get; set; }

        public List<Event> Tue { get; set; }

        public List<Event> Wed { get; set; }

        public List<Event> Thu { get; set; }

        public List<Event> Fri { get; set; }

        public List<Event> Sat { get; set; }

        public List<Event> Sun { get; set; }
    }
}
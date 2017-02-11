using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZenithDataLib.Models;
using System.Data.Entity;
using ZenithSociety.Models;

namespace ZenithSociety.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Event> MonEvents = new List<Event>();
            List<Event> TueEvents = new List<Event>();
            List<Event> WedEvents = new List<Event>();
            List<Event> ThuEvents = new List<Event>();
            List<Event> FirEvents = new List<Event>();
            List<Event> SatEvents = new List<Event>();
            List<Event> SunEvents = new List<Event>();

            using (var db = new ApplicationDbContext())
            {
                DateTime startDate = DateTime.Today.Date.AddDays(-(int)DateTime.Today.DayOfWeek), // prev sunday 00:00
                         endDate = startDate.AddDays(7); // next sunday 00:00 

                var start = startDate.AddHours(24.01);
                var end = endDate.AddHours(24.01);

                // select the current week events
                var eventsCurWeek = from e in db.Events.Include(a => a.Activity)
                                    where e.EventFrom > start && e.EventFrom <= end && e.IsActive
                                    select e;


                // filter the data
                foreach(var eve in eventsCurWeek)
                {
                    var cc = MonEvents.Count;

                    if((int)eve.EventFrom.DayOfWeek == 1)
                    {
                        MonEvents.Add(eve);
                    } else if((int)eve.EventFrom.DayOfWeek == 2)
                    {
                        TueEvents.Add(eve);
                    } else if((int)eve.EventFrom.DayOfWeek == 3)
                    {
                        WedEvents.Add(eve);
                    } else if((int)eve.EventFrom.DayOfWeek == 4)
                    {
                        ThuEvents.Add(eve);
                    } else if((int)eve.EventFrom.DayOfWeek == 5)
                    {
                        FirEvents.Add(eve);
                    } else if((int)eve.EventFrom.DayOfWeek == 6)
                    {
                        SatEvents.Add(eve);
                    } else
                    {
                        SunEvents.Add(eve);
                    }
                    
                }

                // prepare the ViewModel
                HomeViewModel hvm = new HomeViewModel();
                hvm.Mon = MonEvents;
                hvm.Tue = TueEvents;
                hvm.Wed = WedEvents;
                hvm.Thu = ThuEvents;
                hvm.Fri = FirEvents;
                hvm.Sat = SatEvents;
                hvm.Sun = SunEvents;

                return View(hvm);
            }
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
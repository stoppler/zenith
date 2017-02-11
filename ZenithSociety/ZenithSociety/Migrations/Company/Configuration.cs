namespace ZenithSociety.Migrations.Company
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ZenithDataLib.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ZenithDataLib.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Company";
        }

        protected override void Seed(ZenithDataLib.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Activities.AddOrUpdate(a => a.Description, getActivities());
            context.SaveChanges();
            context.Events.AddOrUpdate(e => new { e.CreationDate, e.EventFrom, e.EventTo}, getEvents(context));
        }

        private Activity[] getActivities()
        {
            var activities = new List<Activity>
            {
                new Activity()
                {
                    Description = "Playing Golf",
                    CreationDate = new DateTime(2017, 2, 1, 7, 0, 0)
                },

                new Activity()
                {
                    Description = "Swimming",
                    CreationDate = new DateTime(2017, 1, 15, 8, 30, 0)
                },

                new Activity()
                {
                    Description = "Leadership General Assembly meeting",
                    CreationDate = new DateTime(2017, 1, 25, 8, 30, 0)
                },

                new Activity()
                {
                    Description = "Youth Bowling Tournament",
                    CreationDate = new DateTime(2017, 1, 25, 8, 30, 0)
                },

                new Activity()
                {
                    Description = "Young ladies cooking lessons",
                    CreationDate = new DateTime(2017, 1, 25, 8, 30, 0)
                },

                new Activity()
                {
                    Description = "BBQ Lunch",
                    CreationDate = new DateTime(2017, 1, 25, 8, 30, 0)
                },
            };

            return activities.ToArray();
        }

        private Event[] getEvents(ApplicationDbContext context)
        {
            var events = new List<Event>
            {
                new Event()
                {
                    EventFrom = new DateTime(2017, 1, 25, 8, 30, 0),
                    EventTo = new DateTime(2017, 1, 25, 10, 30, 0),
                    UserName = "a",
                    CreationDate = new DateTime(2017, 1, 24, 10, 30, 0),
                    IsActive = true,
                    Activity = context.Activities.Find(9)
                },

                new Event()
                {
                    EventFrom = new DateTime(2017, 2, 6, 13, 30, 0),
                    EventTo = new DateTime(2017, 2, 6, 15, 30, 0),
                    UserName = "a",
                    CreationDate = new DateTime(2017, 1, 24, 10, 30, 0),
                    IsActive = true,
                    Activity = context.Activities.Find(9)
                },

                new Event()
                {
                    EventFrom = new DateTime(2017, 2, 6, 13, 30, 0),
                    EventTo = new DateTime(2017, 2, 6, 15, 30, 0),
                    UserName = "a",
                    CreationDate = new DateTime(2017, 1, 24, 10, 30, 0),
                    IsActive = true,
                    Activity = context.Activities.Find(10)
                },

                new Event()
                {
                    EventFrom = new DateTime(2017, 2, 7, 8, 30, 0),
                    EventTo = new DateTime(2017, 2, 7, 11, 20, 0),
                    UserName = "a",
                    CreationDate = new DateTime(2017, 1, 24, 10, 30, 0),
                    IsActive = true,
                    Activity = context.Activities.Find(11)
                },

                new Event()
                {
                    EventFrom = new DateTime(2017, 2, 8, 11, 30, 0),
                    EventTo = new DateTime(2017, 2, 8, 13, 30, 0),
                    UserName = "a",
                    CreationDate = new DateTime(2017, 1, 24, 10, 30, 0),
                    IsActive = true,
                    Activity = context.Activities.Find(11)
                },

                new Event()
                {
                    EventFrom = new DateTime(2017, 2, 9, 11, 30, 0),
                    EventTo = new DateTime(2017, 2, 9, 13, 30, 0),
                    UserName = "a",
                    CreationDate = new DateTime(2017, 1, 24, 10, 30, 0),
                    IsActive = true,
                    Activity = context.Activities.Find(12)
                },

                new Event()
                {
                    EventFrom = new DateTime(2017, 2, 10, 11, 30, 0),
                    EventTo = new DateTime(2017, 2, 10, 13, 30, 0),
                    UserName = "a",
                    CreationDate = new DateTime(2017, 1, 24, 10, 30, 0),
                    IsActive = true,
                    Activity = context.Activities.Find(12)
                },

                new Event()
                {
                    EventFrom = new DateTime(2017, 2, 11, 11, 30, 0),
                    EventTo = new DateTime(2017, 2, 11, 13, 30, 0),
                    UserName = "a",
                    CreationDate = new DateTime(2017, 1, 24, 10, 30, 0),
                    IsActive = true,
                    Activity = context.Activities.Find(13)
                },

                new Event()
                {
                    EventFrom = new DateTime(2017, 2, 12, 11, 30, 0),
                    EventTo = new DateTime(2017, 2, 12, 13, 30, 0),
                    UserName = "a",
                    CreationDate = new DateTime(2017, 1, 24, 10, 30, 0),
                    IsActive = true,
                    Activity = context.Activities.Find(14)
                },
                //new data 
                new Event()
                {
                    EventFrom = new DateTime(2017, 2, 13, 13, 30, 0),
                    EventTo = new DateTime(2017, 2, 13, 15, 30, 0),
                    UserName = "a",
                    CreationDate = new DateTime(2017, 1, 24, 10, 30, 0),
                    IsActive = true,
                    Activity = context.Activities.Find(9)
                },

                new Event()
                {
                    EventFrom = new DateTime(2017, 2, 14, 13, 30, 0),
                    EventTo = new DateTime(2017, 2, 14, 15, 30, 0),
                    UserName = "a",
                    CreationDate = new DateTime(2017, 1, 24, 10, 30, 0),
                    IsActive = true,
                    Activity = context.Activities.Find(10)
                },

                new Event()
                {
                    EventFrom = new DateTime(2017, 2, 15, 8, 30, 0),
                    EventTo = new DateTime(2017, 2, 15, 11, 20, 0),
                    UserName = "a",
                    CreationDate = new DateTime(2017, 1, 24, 10, 30, 0),
                    IsActive = true,
                    Activity = context.Activities.Find(11)
                },

                new Event()
                {
                    EventFrom = new DateTime(2017, 2, 16, 11, 30, 0),
                    EventTo = new DateTime(2017, 2, 16, 13, 30, 0),
                    UserName = "a",
                    CreationDate = new DateTime(2017, 1, 24, 10, 30, 0),
                    IsActive = true,
                    Activity = context.Activities.Find(11)
                },

                new Event()
                {
                    EventFrom = new DateTime(2017, 2, 17, 11, 30, 0),
                    EventTo = new DateTime(2017, 2, 17, 13, 30, 0),
                    UserName = "a",
                    CreationDate = new DateTime(2017, 1, 24, 10, 30, 0),
                    IsActive = true,
                    Activity = context.Activities.Find(12)
                },

                new Event()
                {
                    EventFrom = new DateTime(2017, 2, 18, 11, 30, 0),
                    EventTo = new DateTime(2017, 2, 18, 13, 30, 0),
                    UserName = "a",
                    CreationDate = new DateTime(2017, 1, 24, 10, 30, 0),
                    IsActive = true,
                    Activity = context.Activities.Find(12)
                },

                new Event()
                {
                    EventFrom = new DateTime(2017, 2, 19, 11, 30, 0),
                    EventTo = new DateTime(2017, 2, 19, 13, 30, 0),
                    UserName = "a",
                    CreationDate = new DateTime(2017, 1, 24, 10, 30, 0),
                    IsActive = true,
                    Activity = context.Activities.Find(13)
                },

                new Event()
                {
                    EventFrom = new DateTime(2017, 2, 20, 11, 30, 0),
                    EventTo = new DateTime(2017, 2, 20, 13, 30, 0),
                    UserName = "a",
                    CreationDate = new DateTime(2017, 1, 24, 10, 30, 0),
                    IsActive = true,
                    Activity = context.Activities.Find(14)
                },
                new Event()
                {
                    EventFrom = new DateTime(2017, 2, 21, 13, 30, 0),
                    EventTo = new DateTime(2017, 2, 21, 15, 30, 0),
                    UserName = "a",
                    CreationDate = new DateTime(2017, 1, 24, 10, 30, 0),
                    IsActive = true,
                    Activity = context.Activities.Find(9)
                },

                new Event()
                {
                    EventFrom = new DateTime(2017, 2, 21, 13, 30, 0),
                    EventTo = new DateTime(2017, 2, 21, 15, 30, 0),
                    UserName = "a",
                    CreationDate = new DateTime(2017, 1, 24, 10, 30, 0),
                    IsActive = true,
                    Activity = context.Activities.Find(10)
                },

                new Event()
                {
                    EventFrom = new DateTime(2017, 2, 22, 8, 30, 0),
                    EventTo = new DateTime(2017, 2, 22, 11, 20, 0),
                    UserName = "a",
                    CreationDate = new DateTime(2017, 1, 24, 10, 30, 0),
                    IsActive = true,
                    Activity = context.Activities.Find(11)
                },

                new Event()
                {
                    EventFrom = new DateTime(2017, 2, 23, 11, 30, 0),
                    EventTo = new DateTime(2017, 2, 23, 13, 30, 0),
                    UserName = "a",
                    CreationDate = new DateTime(2017, 1, 24, 10, 30, 0),
                    IsActive = true,
                    Activity = context.Activities.Find(11)
                },

                new Event()
                {
                    EventFrom = new DateTime(2017, 2, 24, 11, 30, 0),
                    EventTo = new DateTime(2017, 2, 24, 13, 30, 0),
                    UserName = "a",
                    CreationDate = new DateTime(2017, 1, 24, 10, 30, 0),
                    IsActive = true,
                    Activity = context.Activities.Find(12)
                },

                new Event()
                {
                    EventFrom = new DateTime(2017, 2, 25, 11, 30, 0),
                    EventTo = new DateTime(2017, 2, 25, 13, 30, 0),
                    UserName = "a",
                    CreationDate = new DateTime(2017, 1, 24, 10, 30, 0),
                    IsActive = true,
                    Activity = context.Activities.Find(12)
                },

                new Event()
                {
                    EventFrom = new DateTime(2017, 2, 26, 11, 30, 0),
                    EventTo = new DateTime(2017, 2, 26, 13, 30, 0),
                    UserName = "a",
                    CreationDate = new DateTime(2017, 1, 24, 10, 30, 0),
                    IsActive = true,
                    Activity = context.Activities.Find(13)
                },

                new Event()
                {
                    EventFrom = new DateTime(2017, 2, 27, 11, 30, 0),
                    EventTo = new DateTime(2017, 2, 27, 13, 30, 0),
                    UserName = "a",
                    CreationDate = new DateTime(2017, 1, 24, 10, 30, 0),
                    IsActive = true,
                    Activity = context.Activities.Find(14)
                },
                new Event()
                {
                    EventFrom = new DateTime(2017, 2, 28, 13, 30, 0),
                    EventTo = new DateTime(2017, 2, 28, 15, 30, 0),
                    UserName = "a",
                    CreationDate = new DateTime(2017, 1, 24, 10, 30, 0),
                    IsActive = true,
                    Activity = context.Activities.Find(9)
                },

                new Event()
                {
                    EventFrom = new DateTime(2017, 2, 28, 13, 30, 0),
                    EventTo = new DateTime(2017, 2, 28, 15, 30, 0),
                    UserName = "a",
                    CreationDate = new DateTime(2017, 1, 24, 10, 30, 0),
                    IsActive = true,
                    Activity = context.Activities.Find(10)
                },

                new Event()
                {
                    EventFrom = new DateTime(2017, 2, 28, 8, 30, 0),
                    EventTo = new DateTime(2017, 2, 28, 11, 20, 0),
                    UserName = "a",
                    CreationDate = new DateTime(2017, 1, 24, 10, 30, 0),
                    IsActive = true,
                    Activity = context.Activities.Find(11)
                },

               
            };

            return events.ToArray();
        }
    }
}

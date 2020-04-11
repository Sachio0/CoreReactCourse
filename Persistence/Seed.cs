using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext dataContext)
        {
            if(!dataContext.Activities.Any())
            {
                var activities = new List<Activity>
                {
                    new Activity
                    {
                        Title = "A1",
                        Date = DateTime.Now.AddMonths(1),
                        Description = "Description A1",
                        Category = "Film",
                        City= "Przyszowice",
                        Venue = "Cinema"
                    },
                    new Activity
                    {
                        Title = "A2",
                        Date = DateTime.Now.AddMonths(2),
                        Description = "Description A2",
                        Category = "Film",
                        City= "Przyszowice",
                        Venue = "Cinema"
                    },
                    new Activity
                    {
                        Title = "A3",
                        Date = DateTime.Now.AddMonths(3),
                        Description = "Description A3",
                        Category = "Film",
                        City= "Przyszowice",
                        Venue = "Cinema"
                    },
                    new Activity
                    {
                        Title = "A4",
                        Date = DateTime.Now.AddMonths(4),
                        Description = "Description A4",
                        Category = "Film",
                        City= "Przyszowice",
                        Venue = "Cinema"
                    },
                    new Activity
                    {
                        Title = "A5",
                        Date = DateTime.Now.AddMonths(5),
                        Description = "Description A5",
                        Category = "Film",
                        City= "Przyszowice",
                        Venue = "Cinema"
                    }

                };
                dataContext.Activities.AddRange(activities);
                dataContext.SaveChanges();
            }
        }
    }
}

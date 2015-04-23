using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleOData.Models;

namespace SimpleOData.DataSource
{
    public class DemoDataSources
    {
        private static DemoDataSources instance = null;

        public static DemoDataSources Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DemoDataSources();
                }
                return instance;
            }
        }

        public List<Person> People = new List<Person>();
        public List<Trip> Trips = new List<Trip>();

        private DemoDataSources()
        {
            this.Reset();
            this.Initialize();
        }

        private void Initialize()
        {
            this.Trips.AddRange(new List<Trip> {
                new Trip {ID = "0", Name = "Trip 0"},
                new Trip {ID = "1", Name = "Trip 1"},
                new Trip {ID = "2", Name = "Trip 2"}
            });

            this.People.AddRange(new List<Person> {
                new Person {ID = "001", Name = "Angel", Trips = new List<Trip>{Trips[0], Trips[1]}}
            });
        }

        public void Reset()
        {
            this.People = new List<Person>();
        }
    }
}
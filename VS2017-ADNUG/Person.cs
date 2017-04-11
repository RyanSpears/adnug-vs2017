using System;
using System.Collections.Generic;

namespace VS2017_ADNUG
{
    public class Person
    {
        public List<Person> Friends { get; set; } = new List<Person>();

        public Person()
        {
            // Show IntelliSense (filtering, CamelCase matching)
            this.FirstName = "Ryan";

            // Show Run To Click
            this.LastName = "Spears";

            // Show improved Exception Helper
            // throw new Exception("Show improved exception message details");
        }

        public void AddFriend(string firstName, string lastName, DateTime dob)
        {
            // Show refactorings
            var p = new Person();

            p.FirstName = firstName;
            p.LastName = lastName;
            p.DateOfBirth = dob;
            p.FullName = string.Format("{0} {1}", this.FirstName, this.LastName);

            p.Friends.Add(p);
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string FullName { get; set; }
    }
}
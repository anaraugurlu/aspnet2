using aspnet2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet2.FakeRepo
{
    public class PersonRepo
    {
        public static List<Person> Persons { get; set; } = new List<Person>
        {
          new Person{Name="user1",ImageUrl="1.jpg"},
          new Person{Name="user2",ImageUrl="1.jpg"},
          new Person{Name="user3",ImageUrl="1.jpg"},
        };
    }
}

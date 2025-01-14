using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project___Fitness
{
    public class Member
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Card Card { get; set; }
        
        public Member(int ID, string Name, int Age,Card Card)
        {
            this.ID = ID;
            this.Name = Name;
            this.Age = Age;
            this.Card = Card;
        }
    }
}

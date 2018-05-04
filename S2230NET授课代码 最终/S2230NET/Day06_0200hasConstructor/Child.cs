using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_0200hasConstructor
{
    public class Child:Parent
    {
        private string homeAddress;//见名知意 

        public Child() { }

        public Child(int age2,string name2,string homeAddress):base(name2,age2) 
        {
            //base.Name = name;
            //base.Age = age;
            this.homeAddress = homeAddress;
        }

        public string HomeAddress
        {
            get { return homeAddress; }
            set { homeAddress = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_5_linq
{
    public class Person
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public int Age { get; set; }

     
       override public string ToString() => $"Id: {Id}, Nome: {Name}, Idade:  {Age}, Telefone: {Telephone}";

    }
}

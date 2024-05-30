using _29_5_linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_5_linq
{
    public class Adm
    {
        public static List<Person> LoadData()
        {
            var people = new List<Person>();
            people.Add(new Person() { Id = 1, Name = "Juliana", Age = 15, Telephone = "99999" });
            people.Add(new Person() { Id = 2, Name = "Jaqueline", Age = 16, Telephone = "98999" });
            people.Add(new Person() { Id = 3, Name = "Danilo", Age = 17, Telephone = "99979" });
            people.Add(new Person() { Id = 4, Name = "Elizete", Age = 18, Telephone = "96999" });
            people.Add(new Person() { Id = 5, Name = "Antonio", Age = 29, Telephone = "95999" });
            return people;
        }
        public static void PrintData(List<Person> people)
        {
            foreach (var p in people)
            {
                Console.WriteLine(p);
            }
        }
        //retornar resultados do filtro aplicado
        public static List<Person> FilterByAge(List<Person> people)
        {
            List<Person> result = new List<Person>();
            foreach (var p in people)
            {
                if (p.Age >= 18)
                {
                    result.Add(p);
                }
            }
            return result;
        }
        public static List<Person> FilterByAgeUseLinq(List<Person> people) => people.Where(p => p.Age >= 18).ToList();


        public static List<Person> FilterByAge1(List<Person> people)
        {
            List<Person> result = new List<Person>();
            foreach (var p in people)
            {
                if (p.Age < 18)
                {
                    result.Add(p);
                }
            }
            return result;
        }
        public static List<Person> FilterByAgeUseLinq1(List<Person> people) => people.Where(p => p.Age < 18).ToList();


        public static List<Person> FilterByNameUseLinq(List<Person> people) => people.Where(p => p.Name.StartsWith("A")).ToList();

        public static List<Person> FilterOrderByNameUseLinq(List<Person> people) => people.OrderBy(p => p.Name).ToList();

        public static List<Person> FilterOrderByNamedescUseLinq(List<Person> people) => people.OrderByDescending(p => p.Name).ToList();

        public static List<Person> FilterOrderByNameA(List<Person> people) => people.Where(p => p.Name.Contains("A", StringComparison.OrdinalIgnoreCase) && p.Name.Length > 3).ToList();
    }
}
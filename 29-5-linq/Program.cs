using _29_5_linq;
using System;

Console.WriteLine("        >>>>>INÍCIO DO PROCESSAMENTO<<<<<\n");


var people = Adm.LoadData();
Adm.PrintData(people);
Console.ReadKey();

Console.WriteLine("\nListar todas as pessoas que tem MAIS de 18 anos: ");
Adm.PrintData(Adm.FilterByAge(people));
Console.ReadKey();

Console.WriteLine("\nListar todas as pessoas que tem MENOS de 18 anos: ");
Adm.PrintData(Adm.FilterByAge1(people));
Console.ReadKey();

Console.WriteLine("\nListar todas as pessoas que tem o nome que inicia coma letra A: ");
Adm.PrintData(Adm.FilterByNameUseLinq(people));
Console.ReadKey();

Console.WriteLine("\nListar todas as pessoas por ordem alfabética: ");
Adm.PrintData(Adm.FilterOrderByNameUseLinq(people));
Console.ReadKey();

Console.WriteLine("\nListar todas as pessoas por ordem alfabética decrescente: ");
Adm.PrintData(Adm.FilterOrderByNamedescUseLinq(people));
Console.ReadKey();

Console.WriteLine("\nListar todas as pessoas que tenham a letra 'a' no nome e o nome tem que ter mais que 3 caracteres: ");
Adm.PrintData(Adm.FilterOrderByNameA(people));
Console.ReadKey();
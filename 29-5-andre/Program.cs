using _29_5_andre;
using System.Data.SqlClient;

Console.WriteLine("");



var lst = ReadFile.GetData("C:\\Users\\jumis\\motoristas_habilitados.json");

//foreach (var item in lst)
//{
///    Console.WriteLine(item);
//}


//Console.WriteLine("Quantidade de linhas: " + TestFilters.getCountRecords(lst));
//Console.ReadKey();

//Console.WriteLine("Encontrar registros que tenham o número do documento iniciando com 237.");
//List<PenalidadesAplicadas> consultaCpf = TestFilters.FilterByNumbercpfLinq(lst);
////TestFilters.PrintData(consultaCpf);
//Console.WriteLine("Quantidade de registros: " + TestFilters.getCountRecords(consultaCpf));
//Console.ReadKey();
//Console.ReadLine();


//Console.WriteLine("Listar registros que tem o ano de vigência igual a 2021.");
//List<PenalidadesAplicadas> consultaAno = TestFilters.FilterByAnoLinq(lst);
////TestFilters.PrintData(consultaAno);
//Console.WriteLine("Quantidade de registros " + TestFilters.getCountRecords(consultaAno));
//Console.ReadLine();
//Console.ReadKey();

//Console.WriteLine("Quantas empresas tem no nome da razão social a descrição LTDA?");
//List<PenalidadesAplicadas> ltda = TestFilters.FilterByRazaoSocial(lst);
//Console.WriteLine("Quantidade:  " + TestFilters.getCountRecords(ltda));
////TestFilters.PrintData(consultaAno);
//Console.ReadLine();
//Console.ReadKey();

//Console.WriteLine("Ordenar a lista de registro pela razão social.");
//List < PenalidadesAplicadas > razaoSocial  = TestFilters.OrderByRazaoSocialUseLinq(lst);
////TestFilters.PrintData(razaoSocial);
//Console.ReadLine();
//Console.ReadKey();

//Console.WriteLine("Encontrar cnpj iguais.");
//List<PenalidadesAplicadas> consultacnpj = TestFilters.GroupByCnpjUseLinq(lst);
////TestFilters.PrintData(consultacnpj);
//Console.WriteLine("Cnpj iguais: " + TestFilters.getCountRecords(consultacnpj));
//Console.ReadKey();
Console.ReadLine();

Console.WriteLine("Inserir todos os registros no SqlServer.");
SqlBD.Salvar(lst);
Console.ReadLine();
Console.ReadKey();

// consulta dados do SQL Server e coloca numa List<PenalidadesAplicadas>
// SqlBD.Consultar()

// MongoBD.Salvar(listaPenalidades)
Console.WriteLine("Gerar XML.");



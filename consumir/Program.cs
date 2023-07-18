// See https://aka.ms/new-console-template for more information
using consumir;
using Flurl.Http;

Console.WriteLine("Hello, World!");
#region Metodo inserir e lista ###
string url = "http://localhost:5269";

Tipo Animal = new Tipo();
string ponto = url + "/api/Animal/";

        System.Console.WriteLine("Digite um id");
        Animal.Id = Convert.ToInt16(Console.ReadLine());
        System.Console.WriteLine("Digite um Nome");
        Animal.Nome = Console.ReadLine();
        System.Console.WriteLine("Digite se está true(ativo) ou false(Desativado)");
        Animal.Ativo = Convert.ToBoolean(Console.ReadLine());
        var result = await ponto.PostJsonAsync(Animal);
        System.Console.WriteLine(result.StatusCode);

    System.Console.WriteLine("List");

   IEnumerable<Tipo> lista = await ponto.GetJsonAsync<IEnumerable<Tipo>>();
     
    foreach (var item in lista)
    {
        System.Console.WriteLine(item.Id +"-"+item.Nome + " = "+ item.Ativo);
    } 
      
#endregion


System.Console.WriteLine("--------- put");
System.Console.WriteLine("Digite id para deletar");
long id = Convert.ToInt64(Console.ReadLine());
 var del  = url + "/api/Animal/{id}";

 await del.PostAsync(CancellationToken.None,Animal.Id,HttpCompletionOption.ResponseContentRead);


System.Console.WriteLine("=============");

     
    foreach (var item in lista)
    {
        System.Console.WriteLine(item.Id +"-"+item.Nome + " = "+ item.Ativo);
    }



Thread.Sleep(new TimeSpan(0, 0, 5));




Console.WriteLine("Click para saie!");
Console.Read();









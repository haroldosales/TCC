// See https://aka.ms/new-console-template for more information
using consumir;
using Flurl.Http;



        string url = "http://localhost:5269/";
        string methodPost = url + "api/Animal";
      


        Tipo animal = new Tipo();
        animal.Id = Convert.ToInt64(Console.ReadLine());
        animal.Nome = Console.ReadLine();
        animal.Ativo = Convert.ToBoolean(Console.ReadLine());
 await methodPost.PostJsonAsync(animal);








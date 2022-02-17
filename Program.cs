// // See https://aka.ms/new-console-template for more information


// Menu();

// static void Menu()
// {
//     Console.Clear();
//     Console.WriteLine(" O QUE VOCE DESEJA FAZER ?");
//     Console.WriteLine(" 1 - ABRIR ARQUIVO");
//     Console.WriteLine(" 2 - CRIAR ARQUIVO");
//     Console.WriteLine(" 0 - SAIR");
//     short option = short.Parse(Console.ReadLine());
//     switch (option)
//     {
//         case 0: System.Environment.Exit(0); break;
//         case 1: Abrir(); break;
//         case 2: Editar(); break;
//         default: Menu(); break;

//     }
// }

// static void Abrir()
// {

//     // using (var file = new StreamReader())
//     // {
//     //     string text = file.ReadToEnd();
//     //     Console.WriteLine(text);
//     // }


// }


// static void Editar()
// {
//     Console.Clear();
//     Console.WriteLine("Digite seu texto abaixo(ESC para sair)");
//     Console.WriteLine("-------------------------------");
//     string text = "";
//     do
//     {
//         text += Console.ReadLine();
//         text += Environment.NewLine;

//     } while (Console.ReadKey().Key != ConsoleKey.DownArrow);



//     Salvar(text);




// }


// static void Salvar(string text)
// {
//     Console.Clear();
//     Console.WriteLine("QUAL CAMINHO PARA SALVAR O ARQUIVO");
//     var path = Console.ReadLine();
//     using (var file = new StreamWriter(path))
//     {
//         file.Write(text);
//     }

//     Console.WriteLine("Arquivo salvo com sucesso");
//     Menu();
// }




//DATAS 


// var data = new DateTime(2020, 10, 12, 8, 23, 14);
// var data = DateTime.UtcNow;





// // if (data == DateTime.Now.Date)
// // {
// //     Console.WriteLine("é igual");
// // }

// Console.WriteLine(data);



// ARRAYS

// int[] arr = new int[5] { 1, 2, 3, 4, 5 };

// var funcionarios = new Funcionario[5];
// funcionarios[0] = new Funcionario()
// {
//     Id = 2579,
//     Nome = "Rogerio"
// };


// for (int i = 0; i < arr.Length; i++)
// {
//     Console.WriteLine(arr[i]);
// }

// foreach (var f in funcionarios)
// {
//     Console.WriteLine(f.Id + f.Nome);
// }


// public struct Funcionario
// {
//     public int Id { get; set; }

//     public string Nome { get; set; }
// }


// var arr = new int[3];


// try
// {

//     // for (int index = 0; index < 10; index++)
//     // {
//     //     Console.WriteLine(arr[index]);
//     // }
//     Salvar("");
// }

// catch (IndexOutOfRangeException e)
// {

//     Console.WriteLine("Nao encontrei o indice da lista");
//     Console.WriteLine(e.Message);

// }

// catch (Exception e)
// {
//     Console.WriteLine(e.InnerException);
//     Console.WriteLine(e.Message);
// }

// finally
// {
//     Console.WriteLine("CHEGOU AO FIM");
// }

// static void Salvar(string texto)
// {
//     if (string.IsNullOrEmpty(texto))
//     {
//         throw new Exception("o texto nao pode ser nulo");
//     }
// }


// public class MyException : Exception
// {
//     public DateTime QuandoAconteceu { get; set; }
// }

Menu.Show();
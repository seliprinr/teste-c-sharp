const string textoolamundo = "Hey!"
string nomecompleto;
int idade;

Console.WriteLine("Qual o seu nome completo?");

nomecompleto = Console.ReadLine().ToString();

Console.WriteLine("Qual a sua idade?");

idade = Convert.ToInt32(Console.ReadLine());

//if (idade == 34 && nomecompleto == "Rodrigo Seliprin")
//{
//    Console.WriteLine(textoolamundo + nomecpmpleto + "que tem" + idade + "anos");
//}
//else
//{
//    Console.WriteLine("Você errou a idade e/ou o nome");
//}


switch(nomecompleto)
{
    case "Daniel Castello": Console.WriteLine("Professor de C#"); break;
    case "Rafael": Console.WriteLine("Professor de Vue.Js"); break;
    case "Filipe": Console.WriteLine("Professor de Python"); break;
    case "Kaique": Console.WriteLine("Professor de Kotlin"); break;
    default: Console.WriteLine("Não possuímos esse professor"); break;
}
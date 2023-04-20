const string textoolamundo = "Hey!"
string nomecompleto;
int idade;

Console.WriteLine("Qual o seu nome completo?");

nomecompleto = Console.ReadLine().ToString();

Console.WriteLine("Qual a sua idade?");

idade = Convert.ToInt32(Console.ReadLine());

if (idade == 34 && nomecompleto == "Rodrigo Seliprin")
{
    Console.WriteLine(textoolamundo + nomecpmpleto + "que tem" + idade + "anos");
}
else
{
    Console.WriteLine("Você errou a idade e/ou o nome");
}
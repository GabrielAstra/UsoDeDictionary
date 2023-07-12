Dictionary<string, string> pessoasCidades = new Dictionary<string, string>();

pessoasCidades.Add("Gabriel", "Brasília");
pessoasCidades.Add("Joao", "Manaus");
pessoasCidades.Add("Marcelo", "Pernambuco");
pessoasCidades.Add("Fernando", "Goias");

foreach (var item in pessoasCidades)
{
    Console.WriteLine($"As pessoas que permanecem na lista são: {item.Key} e as cidades delas são: {item.Value}");
}


Console.WriteLine("--------------------");


pessoasCidades.Remove("Joao");
pessoasCidades["Marcelo"] ="Amazonas !ESTADO ALTERADO!";

foreach (var item in pessoasCidades)
{
    Console.WriteLine($"As pessoas que permanecem na lista são: {item.Key} e as cidades delas são {item.Value}");
}


//Esse bloco de código abaixo será uma função de verificação no Dictionary

Console.WriteLine("--------------------------------");
Console.WriteLine("Digite um nome para verificar se há no Dictionary: ");
string pessoa = Console.ReadLine();

Console.Write($"Verificando se há a pessoa {pessoa} na lista: ");

if(pessoasCidades.ContainsKey(pessoa))
{
    Console.WriteLine("Contem a pessoa");
}
else 
{
    Console.Write("Pessoa não existe na lista");
}


// Como acessar uma Key em um Dictionary ?

// Console.WriteLine(pessoasCidades["Gabriel"]);
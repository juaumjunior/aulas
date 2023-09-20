int idad = 0;
decimal orcamento = 0;
bool temDesconto;

try
{
	Console.WriteLine("Insira sua idade: ");
	idad = int.Parse(Console.ReadLine());

	Console.WriteLine("Insira seu orçamento: ");
	orcamento = decimal.Parse(Console.ReadLine());

	if (idad >= 18)
	{

		if (orcamento >= 30)
		{

			if (idad >= 18)
			{
				if (idad <= 30 && idad >= 18)
				{

					Console.WriteLine("Voce tem duas opçoes, o plano padrao de R$ 30,00 e o plano premium de R$ 50,00");
					Console.WriteLine("Qual voce deseja? padrao ou premium");

					string? tipoPlano = "";

					tipoPlano = Console.ReadLine();

					if (tipoPlano == "padrao")
					{
						if (orcamento >= 30)
						{
							Console.WriteLine("Voce tera um investimento de R$ 30,00");
							Console.WriteLine("seu orçamento esta dentro do necessario, te roubamos: " + (orcamento - 30));
						}
						else
						{
							Console.WriteLine("Saldo Insuficiente: ");
						}
					}
					else if (tipoPlano == "premium")
					{
						if (orcamento > 50)
						{
							Console.WriteLine("Voce tera um investimento de R$ 50,00");
							Console.WriteLine("seu orçamento esta dentro do necessario, te roubamos: " + (orcamento - 50));
						}
						else
						{
							Console.WriteLine("Saldo Insuficiente:");
						}
					}
				}
				else if (idad > 30)
				{

					Console.WriteLine("Voce tem duas opçoes, o plano padrao de R$ 70,00 e o plano premium de R$ 100,00");
					Console.WriteLine("Qual voce deseja? padrao ou premium");

					string? tipoPlano = "";

					tipoPlano = Console.ReadLine();

					if (tipoPlano == "padrao")
					{
						if (orcamento >= 70)
						{
							Console.WriteLine("Voce tera um investimento de R$ 70,00");
							Console.WriteLine("seu orçamento esta dentro do necessario, te roubamos: " + (orcamento - 70));
						}
						else
						{
							Console.WriteLine("Saldo insuficiente! ");
						}

					}
					else if (tipoPlano == "premium")
					{
						if (orcamento >= 100)
						{
							Console.WriteLine("Voce tera um investimento de R$ 100,00");
							Console.WriteLine("seu orçamento esta dentro do necessario, te roubamos: " + (orcamento - 100));
						}
						else
						{
							Console.WriteLine("Saldo insuficiente! ");
						}
					}
				}
			}

		}


		else
		{
			Console.WriteLine("Saldo insuficiente");
		}
	}
	else
	{
		Console.WriteLine("voce é menor de idade sua ingua, vaza daqui:");
	}
}
catch
{
	Console.WriteLine("é numero mano, para de ser burro");
}



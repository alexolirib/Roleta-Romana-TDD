using System;

namespace JogoRoletaPuzzle
{
    public class JogoMorte
    {
		public String ComeceJogo(int quantidadeDePessoas, int passo, int posiçãoAtual)
		{
			if ((quantidadeDePessoas > 0) && (passo > 0) && ((posiçãoAtual >= 1) && (posiçãoAtual <= quantidadeDePessoas)))
			{
				if (quantidadeDePessoas != 1)
				{
					int[] ordemMorte = new int[quantidadeDePessoas];
					int ordem = 0;

					//é deixado em ordem no vetor ordemMorte, a posição de cada morte 
					while (ordem != quantidadeDePessoas)
					{
						ordemMorte[ordem] = posiçãoAtual;
						ordem++;
						posiçãoAtual += passo;

						//para funcionar como um círculo, sempre que passar da QuantidadeDePessoas irá retornar para a 
						//primeira posição e assim seguir a ordem
						while (true)
						{
							if (posiçãoAtual > quantidadeDePessoas)
							{
								posiçãoAtual -= quantidadeDePessoas;
							}
							else
							{
								break;
							}
						}
					}
					
					// É feito uma verificação através do método VerificaMorteMaisDeUmaVez se uma posição foi
					// escolhida mais de uma vez, se for irá buscar em sentindo horário a próxima posição livre
					int[] ordemMorteVerificado = VerificaMorteMaisDeUmaVez(ordemMorte, quantidadeDePessoas);

					String retorno = "Ordem da execução foi ";

					for (int i = 0; i < ordemMorteVerificado.Length - 1; i++)
					{
						retorno += ordemMorteVerificado[i] + ", ";
					}

					return retorno + "sobrevivente foi quem estava na " + ordemMorteVerificado[ordemMorteVerificado.Length - 1] + "º posição";  
				}
				else
				{
					return "Ninguém foi executado, pois só tem 1 participante";
				}
			}
			else
			{
				return "Impossível informar quem foi executado e quem sobreviveu, pois algum parâmetro informado está incorreto";
			}
		}		

		private int[] VerificaMorteMaisDeUmaVez(int[] ordemMorte, int quantidadeDePessoas)
		{
			for (int quemEstaMorrendo = 1; quemEstaMorrendo < ordemMorte.Length; quemEstaMorrendo++)
			{
				for (int verificaMorte = 0; verificaMorte < quemEstaMorrendo; verificaMorte++)
				{
					//É feita a comparação com quem está morrendo com quem já morreu
					if (ordemMorte[quemEstaMorrendo] == ordemMorte[verificaMorte])
					{
						ordemMorte[quemEstaMorrendo]++;

						// É feita uma verificação se ultrapassou o limite de pessoas, se tiver
						// irá retornar para a primeira posição
						if (ordemMorte[quemEstaMorrendo] > quantidadeDePessoas)
						{
							ordemMorte[quemEstaMorrendo] = 1;
						}

						// É zerado o contador para fazer uma nova verificação da nova posição que foi alocado
						verificaMorte = 0;
					}
				}
			}

			return ordemMorte;
		}
	}
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JogoRoletaPuzzle;

namespace JogoRoletaPuzzleTeste
{
	[TestClass]
	public class JogoMorteTeste
	{
		[TestMethod]
		public void Integrante5Passo1Posição1Sobrevive5()
		{
			var teste = new JogoMorte();

			var resultado = teste.ComeceJogo(5, 1, 1);

			Assert.AreEqual("Ordem da execução foi 1, 2, 3, 4, sobrevivente foi quem estava na 5º posição", resultado);
		}

		[TestMethod]
		public void Integrante4Passo1Posição1Sobrevive4()
		{
			var teste = new JogoMorte();

			var resultado = teste.ComeceJogo(4, 1, 1);

			Assert.AreEqual("Ordem da execução foi 1, 2, 3, sobrevivente foi quem estava na 4º posição", resultado);
		}

		[TestMethod]
		public void Integrante5Passo2Posição1Sobrevive4()
		{
			var teste = new JogoMorte();

			var resultado = teste.ComeceJogo(5, 2, 1);

			Assert.AreEqual("Ordem da execução foi 1, 3, 5, 2, sobrevivente foi quem estava na 4º posição", resultado);
		}

		[TestMethod]
		public void Integrante4Passo1Posição2Sobrevive1()
		{
			var teste = new JogoMorte();

			var resultado = teste.ComeceJogo(4, 1, 2);

			Assert.AreEqual("Ordem da execução foi 2, 3, 4, sobrevivente foi quem estava na 1º posição", resultado);
		}

		[TestMethod]
		public void Integrante3Passo2Posição1Sobrevive2()
		{
			var teste = new JogoMorte();

			var resultado = teste.ComeceJogo(3, 2, 1);

			Assert.AreEqual("Ordem da execução foi 1, 3, sobrevivente foi quem estava na 2º posição", resultado);
		}

		[TestMethod]
		public void Integrante6Passo9Posição5Sobrevive4()
		{
			var teste = new JogoMorte();

			var resultado = teste.ComeceJogo(6, 9, 5);

			Assert.AreEqual("Ordem da execução foi 5, 2, 6, 3, 1, sobrevivente foi quem estava na 4º posição", resultado);
		}

		[TestMethod]
		public void Integrante5Passo6Posição3Sobrevive2()
		{
			var teste = new JogoMorte();

			var resultado = teste.ComeceJogo(5, 6, 3);

			Assert.AreEqual("Ordem da execução foi 3, 4, 5, 1, sobrevivente foi quem estava na 2º posição", resultado);
		}

		[TestMethod]
		public void Integrante2Passo1Posição2Sobrevive1()
		{
			var teste = new JogoMorte();

			var resultado = teste.ComeceJogo(2, 1, 2);

			Assert.AreEqual("Ordem da execução foi 2, sobrevivente foi quem estava na 1º posição", resultado);
		}

		[TestMethod]
		public void Integrante3Passo4Posição1Sobrevive3()
		{
			var teste = new JogoMorte();

			var resultado = teste.ComeceJogo(3, 4, 1);

			Assert.AreEqual("Ordem da execução foi 1, 2, sobrevivente foi quem estava na 3º posição", resultado);
		}

		[TestMethod]
		public void Integrante4Passo2Posição2Sobrevive1()
		{
			var teste = new JogoMorte();

			var resultado = teste.ComeceJogo(4, 2, 2);

			Assert.AreEqual("Ordem da execução foi 2, 4, 3, sobrevivente foi quem estava na 1º posição", resultado);
		}

		[TestMethod]
		public void Integrante12Passo3Posição5Sobrevive4()
		{
			var teste = new JogoMorte();

			var resultado = teste.ComeceJogo(12, 3, 5);

			Assert.AreEqual("Ordem da execução foi 5, 8, 11, 2, 6, 9, 12, 3, 7, 10, 1, sobrevivente foi quem estava na 4º posição", resultado);
		}

		[TestMethod]
		public void Integrante30Passo4Posição18Sobrevive15()
		{
			var teste = new JogoMorte();

			var resultado = teste.ComeceJogo(30, 4, 18);

			Assert.AreEqual("Ordem da execução foi 18, 22, 26, 30, 4, 8, 12, 16, 20, 24, 28, 2, 6, 10, 14, 19, 23, 27, 1, 5, 9, 13, 17, 21, 25, 29, 3, 7, 11, sobrevivente foi quem estava na 15º posição", resultado);
		}

		[TestMethod]
		public void IntegranteMenos5Passo3Posição2ParametroIncorreto()
		{
			var teste = new JogoMorte();

			var resultado = teste.ComeceJogo(-5, 3, 2);

			Assert.AreEqual("Impossível informar quem foi executado e quem sobreviveu, pois algum parâmetro informado está incorreto", resultado);
		}

		[TestMethod]
		public void Integrante5PassoMenos3Posição2ParametroIncorreto()
		{
			var teste = new JogoMorte();

			var resultado = teste.ComeceJogo(5, -3, 2);

			Assert.AreEqual("Impossível informar quem foi executado e quem sobreviveu, pois algum parâmetro informado está incorreto", resultado);
		}

		[TestMethod]
		public void Integrante5Passo3PosiçãoMenos2ParametroIncorreto()
		{
			var teste = new JogoMorte();

			var resultado = teste.ComeceJogo(5, 3, -2);

			Assert.AreEqual("Impossível informar quem foi executado e quem sobreviveu, pois algum parâmetro informado está incorreto", resultado);
		}

		[TestMethod]
		public void Integrante5Passo3Posição0ParametroIncorreto()
		{
			var teste = new JogoMorte();

			var resultado = teste.ComeceJogo(5, 3, 0);

			Assert.AreEqual("Impossível informar quem foi executado e quem sobreviveu, pois algum parâmetro informado está incorreto", resultado);
		}

		[TestMethod]
		public void Integrante5Passo3Posição6ParametroIncorreto()
		{
			var teste = new JogoMorte();

			var resultado = teste.ComeceJogo(5, 3, 6);

			Assert.AreEqual("Impossível informar quem foi executado e quem sobreviveu, pois algum parâmetro informado está incorreto", resultado);
		}

		[TestMethod]
		public void Integrante0Passo0Posição0ParametroIncorreto()
		{
			var teste = new JogoMorte();

			var resultado = teste.ComeceJogo(0, 0, 0);

			Assert.AreEqual("Impossível informar quem foi executado e quem sobreviveu, pois algum parâmetro informado está incorreto", resultado);
		}

		[TestMethod]
		public void Integrante1Passo2Posição3ParametroIncorreto()
		{
			var teste = new JogoMorte();

			var resultado = teste.ComeceJogo(1, 2, 3);

			Assert.AreEqual("Impossível informar quem foi executado e quem sobreviveu, pois algum parâmetro informado está incorreto", resultado);
		}

		[TestMethod]
		public void Integrante6Passo291Posição3Sobrevive2()
		{
			var teste = new JogoMorte();

			var resultado = teste.ComeceJogo(6, 291, 3);

			Assert.AreEqual("Ordem da execução foi 3, 6, 4, 1, 5, sobrevivente foi quem estava na 2º posição", resultado);
		}

		[TestMethod]
		public void Integrante7Passo1Posição1Sobrevive7()
		{
			var teste = new JogoMorte();

			var resultado = teste.ComeceJogo(7, 1, 1);

			Assert.AreEqual("Ordem da execução foi 1, 2, 3, 4, 5, 6, sobrevivente foi quem estava na 7º posição", resultado);
		}

		[TestMethod]
		public void Integrante7Passo8Posição1Sobrevive7()
		{
			var teste = new JogoMorte();

			var resultado = teste.ComeceJogo(7, 8, 1);

			Assert.AreEqual("Ordem da execução foi 1, 2, 3, 4, 5, 6, sobrevivente foi quem estava na 7º posição", resultado);
		}

		[TestMethod]
		public void Integrante3Passo4372Posição1Sobrevive3()
		{
			var teste = new JogoMorte();

			var resultado = teste.ComeceJogo(3, 4372, 1);

			Assert.AreEqual("Ordem da execução foi 1, 2, sobrevivente foi quem estava na 3º posição", resultado);
		}

		[TestMethod]
		public void Integrante4Passo11349Posição2Sobrevive3()
		{
			var teste = new JogoMorte();

			var resultado = teste.ComeceJogo(4, 11349, 2);

			Assert.AreEqual("Ordem da execução foi 2, 3, 4, sobrevivente foi quem estava na 1º posição", resultado);
		}

		[TestMethod]
		public void Integrante1Passo1Posição1Sobrevive1()
		{
			var teste = new JogoMorte();

			var resultado = teste.ComeceJogo(1, 1, 1);

			Assert.AreEqual("Ninguém foi executado, pois só tem 1 participante", resultado);
		}

		[TestMethod]
		public void Integrante1Passo2Posição1Sobrevive1()
		{
			var teste = new JogoMorte();

			var resultado = teste.ComeceJogo(1, 2, 1);

			Assert.AreEqual("Ninguém foi executado, pois só tem 1 participante", resultado);
		}
	}
}

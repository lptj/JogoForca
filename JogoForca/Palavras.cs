using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoForca
{
    public class Palavras
    {
        Random oRND = new Random();
        string palavra = "";

        public void LimparPalavra()
        {
            palavra = "";
        }

        //Método de Sorteio das categorias de palavras
        public string SorteioCategoria()
        {
            int categoria;
            categoria = oRND.Next(1, 5);

            if(categoria == 1)
            {
                return "Animal";
            }
            else if(categoria == 2)
            {
                return "Cidade";
            }
            else if(categoria == 3)
            {
                return "Veiculo";
            }
            else
            {
                return "Eletronico";
            }
        }

        public string SorteiaPalavra(string categoria)
        {
            if (categoria == "Animal")
            {
                palavra = Animal();
            }
            else if (categoria == "Cidade")
            {
                palavra = Cidade();
            }
            else if (categoria == "Veiculo")
            {
                palavra = Veiculo();
            }
            else
            {
                palavra = Eletronico();
            }

            return palavra;
        }

        // Banco de dado (palavras para serem sorteadas)
        private string Animal()
        {
            List<string> Animal = new List<string>();
            Animal.Add("cachorro");
            Animal.Add("gato");
            Animal.Add("coelho");
            Animal.Add("pato");
            Animal.Add("rinoceronte");
            Animal.Add("girafa");
            Animal.Add("elefante");
            Animal.Add("baleia");
            Animal.Add("leao");
            Animal.Add("tigre");
            Animal.Add("galinha");

            int numSort = oRND.Next(Animal.Count);
            string palavra = Animal[numSort];

            return palavra;
        } 
        private string Cidade()
        {
            List<string> Cidade = new List<string>();
            Cidade.Add("indaiatuba");
            Cidade.Add("sorocaba");
            Cidade.Add("votorantim");
            Cidade.Add("boituva");
            Cidade.Add("jundiai");
            Cidade.Add("franca");
            Cidade.Add("itu");

            int numSort = oRND.Next(Cidade.Count);
            string palavra = Cidade[numSort];

            return palavra;
        }
        private string Veiculo()
        {
            List<string> Veiculo= new List<string>();
            Veiculo.Add("carro");
            Veiculo.Add("moto");
            Veiculo.Add("barco");
            Veiculo.Add("aviao");
            Veiculo.Add("bicicleta");
            Veiculo.Add("onibus");
            Veiculo.Add("caminhao");
            Veiculo.Add("trem");

            int numSort = oRND.Next(Veiculo.Count);
            string palavra = Veiculo[numSort];

            return palavra;
        }
        private string Eletronico()
        {
            List<string> Eletronico = new List<string>();
            Eletronico.Add("computador");
            Eletronico.Add("tablet");
            Eletronico.Add("smartphone");
            Eletronico.Add("televisao");
            Eletronico.Add("impressora");

            int numSort = oRND.Next(Eletronico.Count);
            string palavra = Eletronico[numSort];

            return palavra;
        }
    }
}

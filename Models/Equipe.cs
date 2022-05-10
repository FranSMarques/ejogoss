using System;
using System.Collections.Generic;
using System.IO;

namespace EJOGOSS.Models

{

    //: Herança
    //, Interface (contrato da classe)
    public class Equipe : EquipeBase, IEquipe

    {
        public int IdEquipe { get; set; }

        private int idEquipe;

        public string Nome { get; set; }
        public int Imagem { get; set; }

        //variável de dados
        private const string caminhobd = "Database/equioe,csv";


        public Equipe ()
        {

            //método da classe de herança EquipeBase

            CriarPastaOuArquivo(caminhobd);


        }


        //criar uma função que vai receber o objeto EQUIPE
        //e vai retornar no formato de csv. (STRING)


        private string Preparar(Equipe e)
        {

            //return e.idEquipe + ";" + e.Nome + ";" + e.Imagem;


            return $"{ e.idEquipe};{e.Nome};{e.Imagem}";

        }





        public void Criar(Equipe novaequipe)
        {
            throw new System.NotImplementedException();
            string valor = Preparar(novaequipe);

            //array de strings =   na posicao 0 temos o retorno do "Preparar".
            string[] equipe_texto = { valor };

            //arquivo vamos adicionar uma nova linha.
            //caminho do arquivo,  string em formato array.
            File.AppendAllLines(caminhobd, equipe_texto);
        }

        public List<Equipe> LerEquipes()
        {
            throw new System.NotImplementedException();
            List<Equipe> listaEquipes = new List<Equipe>();

            //ler todas as linhas do arquivo csv, armazenar em um array;
            string[] linhas = File.ReadAllLines(caminhobd);

            foreach (string item in linhas)
            {
                // 1; nome da equipe;  caminho da imagem
                string[] linhaEquipe = item.Split(';');

                Equipe equipeAtual = new Equipe();
                equipeAtual.idEquipe = int.Parse(linhaEquipe[0]);
                equipeAtual.Nome = linhaEquipe[1];
                equipeAtual.Imagem = linhaEquipe[2];

                listaEquipes.Add(equipeAtual);
            }
            return listaEquipes;






        }
}

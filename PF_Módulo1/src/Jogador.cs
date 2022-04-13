using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_Módulo1.src
{
    public class Jogador
        
    {
        public string nomeJogador { get; set; }
        public string posicaoJogador { get; set; }
        public int numeroJogador { get; set; }
        public string habilidade1Jogador { get; set; }
        public string habilidade2Jogador { get; set; }
        public string habilidade3Jogador { get; set; }
        public double alturaJogador { get; set; }
        public int pesoJogador { get; set; }
        public string cidadeJogador { get; set; }

        public Jogador(string _nome, string _posicao, int _numero, string _hab1, string _hab2, string _hab3, double _altura, int _peso, string _cidade)
        {

            nomeJogador = _nome;
            posicaoJogador = _posicao;
            numeroJogador = _numero;
            
            //Agilidade, Força, Passe, Cobrança, Cabeceio, Chute, Nenhum  
            habilidade1Jogador = _hab1;
            habilidade2Jogador = _hab2;
            habilidade3Jogador = _hab3;

            //Atributos físicos
            alturaJogador = _altura;
            pesoJogador = _peso;
            cidadeJogador = _cidade;
        }
    }
}

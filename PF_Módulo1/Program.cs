using PF_Módulo1.src;
using System;
using System.Collections.Generic;

namespace PF_Módulo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Jogador> jogadores = new List<Jogador>(
               new Jogador[]
               {
                    new Goleiro("Tim maia","Goleiro",1,"Forte","Bom passe","Nenhum",2.05,95," Rio de Janeiro"),
                    new Goleiro("Carl Johnson (CJ)"," Goleiro",2,"Rápido","Forte","Cabeceio",1.90,92,"Los Santos"),
                    new Goleiro("Nathan Drake"," Goleiro",3,"Rápido","Cobrador de falta","Nenhum",1.87,85,"Los Santos"),
                    new Zagueiro("João victor","Zagueiro",4,"Rápido","Domínio","Nenhum",1.66,64,"Sorocaba"),
                    new Zagueiro("Livinho","Zagueiro",5,"Domínio","Passe","Força",1.60,76,"São Paulo"),
                    new Zagueiro("Casimiro Miguel","Zagueiro",6,"Rápido","Chute","Forte",1.88,76,"Rio de Janeiro"),
                    new Zagueiro("Poze do Rodo","Zagueiro",7,"Forte","Rápido","Passe",1.82,80,"Rio de Janeiro"),
                    new Lateral("Anitta","Lateral",8,"Passe","Domínio","Nenhum",1.63,72,"Rio de Janeiro"),
                    new Lateral("Zeca Pagodinhha","Lateral",9,"Força","Passe","Cabeceio",2.03,93,"Irajá"),
                    new Lateral("Gaules","Lateral",10,"Cabeceio","Nenhum","Rápido",1.83,74,"São Paulo"),
                    new Lateral("Harry Styles","Lateral",11,"Cobrança","Rápido","Passe",1.89,91,"Redditch"),
                    new Volante("Chico Buarque","Volante",12,"Passe","Cobrança","Nenhum",1.66,68,"Rio de Janeiro"),
                    new Volante("Taylor Swift","Volante",13,"Forte","Domínio","Nenhum",1.68,70,"West Reading"),
                    new Volante("Shawn Mendes","Volante",14,"Domínio","Força","Cobrança",1.90,90,"Toronto"),
                    new MeiodeCampo("Gloria Groove","MeiodeCampo",15,"Forte","Cabeceio","Nenhum",1.64,63,"São Paulo"),
                    new MeiodeCampo("Pablo Vittar","MeiodeCampo",16,"Cobrador de falta","Forte","Bom dominio",1.82,90,"São Luis"),
                    new MeiodeCampo("James Cameron","MeiodeCampo",17,"Rasteio","Cabeceio","Cobrança",1.93,90,"Canadá"),
                    new Armador("Steven Spielberg", "Armador",18,"Cabeceio","Rapido","Nenhum",1.87,70,"Ohio"),
                    new Armador("Renato Russo", "Armador",19,"Forte","Bom passe","Bom dominio",1.76,60,"Rio de Janeiro"),
                    new Atacante("Jimi hendrick","Atacante",20,"Bom passe","Rápido","Nenhum",1.83,87,"Seattle"),
                    new Atacante("Huey Lewis","Atacante",21,"Bom Domínio","Força","Rápido",1.84,80,"New York"),
                    new Atacante("Quentin Tarantino","Atacante",22,"Cabeceio","Força","Nenhum",1.73,65,"Tennessee"),
                    new Atacante("Luísa Sonza","Atacante",23,"Bom Domínio","Cabeceio","Nenhum",1.90,98,"São Paulo"),
               });

            Console.WriteLine("Insira qual o número da habilidade gostaria de localizar os jogadores");
            Console.WriteLine("1 Rápido");
            Console.WriteLine("2 Forte");
            Console.WriteLine("3 Passe");
            Console.WriteLine("4 Cabeceio");
            Console.WriteLine("5 Domínio");
            string entrada = Console.ReadLine();

            if (entrada == "1")
            {
                foreach (Jogador jogador in jogadores)
                {
                    if (jogador.habilidade1Jogador == "Rápido")
                    {
                        Console.WriteLine($"Número: {jogador.numeroJogador},Posição: {jogador.posicaoJogador}, Nome: {jogador.nomeJogador}, Cidade: {jogador.cidadeJogador},Altura: {jogador.alturaJogador},Peso: {jogador.pesoJogador}");
                    }
                    else if (jogador.habilidade2Jogador == "Rápido")
                    {
                        Console.WriteLine($"Número: {jogador.numeroJogador},Posição: {jogador.posicaoJogador}, Nome: {jogador.nomeJogador}, Cidade: {jogador.cidadeJogador},Altura: {jogador.alturaJogador},Peso: {jogador.pesoJogador}");
                    }
                    else if (jogador.habilidade3Jogador == "Rápido")
                    {
                        Console.WriteLine($"Número: {jogador.numeroJogador},Posição: {jogador.posicaoJogador}, Nome: {jogador.nomeJogador}, Cidade: {jogador.cidadeJogador},Altura: {jogador.alturaJogador},Peso: {jogador.pesoJogador}");
                    }
                }
            }
            else if (entrada == "2")
            {
                foreach (Jogador jogador in jogadores)
                {
                    if (jogador.habilidade1Jogador == "Forte")
                    {
                        Console.WriteLine($"Número: {jogador.numeroJogador},Posição: {jogador.posicaoJogador}, Nome: {jogador.nomeJogador}, Cidade: {jogador.cidadeJogador},Altura: {jogador.alturaJogador},Peso: {jogador.pesoJogador}");
                    }
                    else if (jogador.habilidade2Jogador == "Forte")
                    {
                        Console.WriteLine($"Número: {jogador.numeroJogador},Posição: {jogador.posicaoJogador}, Nome: {jogador.nomeJogador}, Cidade: {jogador.cidadeJogador},Altura: {jogador.alturaJogador},Peso: {jogador.pesoJogador}");
                    }
                    else if (jogador.habilidade3Jogador == "Forte")
                    {
                        Console.WriteLine($"Número: {jogador.numeroJogador},Posição: {jogador.posicaoJogador}, Nome: {jogador.nomeJogador}, Cidade: {jogador.cidadeJogador},Altura: {jogador.alturaJogador},Peso: {jogador.pesoJogador}");
                    }
                }
            }
            else if (entrada == "3")
            {
                foreach (Jogador jogador in jogadores)
                {
                    if (jogador.habilidade1Jogador == "Passe")
                    {
                        Console.WriteLine($"Número: {jogador.numeroJogador},Posição: {jogador.posicaoJogador}, Nome: {jogador.nomeJogador}, Cidade: {jogador.cidadeJogador},Altura: {jogador.alturaJogador},Peso: {jogador.pesoJogador}");
                    }
                    else if (jogador.habilidade2Jogador == "Passe")
                    {
                        Console.WriteLine($"Número: {jogador.numeroJogador},Posição: {jogador.posicaoJogador}, Nome: {jogador.nomeJogador}, Cidade: {jogador.cidadeJogador},Altura: {jogador.alturaJogador},Peso: {jogador.pesoJogador}");
                    }
                    else if (jogador.habilidade3Jogador == "Passe")
                    {
                        Console.WriteLine($"Número: {jogador.numeroJogador},Posição: {jogador.posicaoJogador}, Nome: {jogador.nomeJogador}, Cidade: {jogador.cidadeJogador},Altura: {jogador.alturaJogador},Peso: {jogador.pesoJogador}");
                    }
                }
            }
            else if (entrada == "4")
            {
                foreach (Jogador jogador in jogadores)
                {
                    if (jogador.habilidade1Jogador == "Cabeceio")
                    {
                        Console.WriteLine($"Número: {jogador.numeroJogador},Posição: {jogador.posicaoJogador}, Nome: {jogador.nomeJogador}, Cidade: {jogador.cidadeJogador},Altura: {jogador.alturaJogador},Peso: {jogador.pesoJogador}");
                    }
                    else if (jogador.habilidade2Jogador == "Cabeceio")
                    {
                        Console.WriteLine($"Número: {jogador.numeroJogador},Posição: {jogador.posicaoJogador}, Nome: {jogador.nomeJogador}, Cidade: {jogador.cidadeJogador},Altura: {jogador.alturaJogador},Peso: {jogador.pesoJogador}");
                    }
                    else if (jogador.habilidade3Jogador == "Cabeceio")
                    {
                        Console.WriteLine($"Número: {jogador.numeroJogador},Posição: {jogador.posicaoJogador}, Nome: {jogador.nomeJogador}, Cidade: {jogador.cidadeJogador},Altura: {jogador.alturaJogador},Peso: {jogador.pesoJogador}");
                    }

                }
            }
            else if (entrada == "5")
            {
                foreach (Jogador jogador in jogadores)
                {
                    if (jogador.habilidade1Jogador == "Domínio")
                    {
                        Console.WriteLine($"Número: {jogador.numeroJogador},Posição: {jogador.posicaoJogador}, Nome: {jogador.nomeJogador}, Cidade: {jogador.cidadeJogador},Altura: {jogador.alturaJogador},Peso: {jogador.pesoJogador}");
                    }
                    else if (jogador.habilidade2Jogador == "Domínio")
                    {
                        Console.WriteLine($"Número: {jogador.numeroJogador},Posição: {jogador.posicaoJogador}, Nome: {jogador.nomeJogador}, Cidade: {jogador.cidadeJogador},Altura: {jogador.alturaJogador},Peso: {jogador.pesoJogador}");
                    }
                    else if (jogador.habilidade3Jogador == "Domínio")
                    {
                        Console.WriteLine($"Número: {jogador.numeroJogador},Posição: {jogador.posicaoJogador}, Nome: {jogador.nomeJogador}, Cidade: {jogador.cidadeJogador},Altura: {jogador.alturaJogador},Peso: {jogador.pesoJogador}");
                    }
                }
            }
        }
    }
}


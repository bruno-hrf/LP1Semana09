using System;
using System.Collections.Generic;

namespace PlayerManager1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<Player> players = new List<Player>() {new Player("Jonny", 500), new Player ("Macaroni", 600)};


            IEnumerable<Player> GetPlayersWithScoreGreaterThan(int score)
            {               
                List<Player> scorePlayers = new List<Player>();

                for (int i=0 ; i < players.Count; i++)
                {
                    if (players[i].Score > score)
                    {
                        scorePlayers.Add(players[i]);
                        Console.WriteLine(scorePlayers[i].Name + ": " + scorePlayers[i].Score);
                    }
                    
                    
                }

                return scorePlayers;

            }
    
            int score= 0;
            bool loop = true;
            while (loop == true)
            {
                Console.WriteLine("\n\nMenu:\n1-Inserir jogador(nome e score)\n2-Listar jogadores\n3-Listar jogadores com Score maior que o inserido\n4-Sair");
                
                int opcao= Convert.ToInt32(Console.ReadLine());
                string name;
                

                switch (opcao)
                {
                    
                    case 1:
                    {   
                        
                        Console.WriteLine("Nome do jogador:");
                        name = Console.ReadLine();
                        Console.WriteLine($"Score de {name}:");
                        score = Convert.ToInt32(Console.ReadLine());

                        players.Add(new Player(name, score));
                        
                        break;
                    }

                    case 2:
                    {                       
                        for (int i = 0; i < players.Count; i++ )
                        {
                            Console.WriteLine(players[i].Name + ": " + players[i].Score);
                        }
                        break;
                    }

                    case 3:
                    {
                    
                        GetPlayersWithScoreGreaterThan(score);
                        break;
                    }
                    
                    
                    case 4:
                    {
                        loop = false;
                        break;
                    }                   
                }
                

            }
            
            
        }       
    }
}

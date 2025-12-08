using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class RockPaperScissors
    {
        /*
          Pedra vence Tesoura.

          Tesoura vence papel.

          Papel vence pedra,

          Duas jogadas idênticas resultam em empate.
           */
        // Complexidade O(1) Constante
        public static string Rps (string p1, string p2)
        {
            if (p1 == "scissors" && p2 == "paper")
            {
                return "Player 1 won!";
            }
            else if (p1 == "rock" && p2 == "scissors") 
            {
                return "Player 1 won!";
            }else if (p1 == "paper" && p2 == "rock")
            {
                return "Player 1 won!";
            }else if (p1 == p2) {
                return "Draw";
            }
            else
            {
                return "Player 2 won!";
            }            
        }
    }
}

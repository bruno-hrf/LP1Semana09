using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager1
{
    public class Player
    {
        public string  Name{ get ; }
        public int Score { get; set; }

        public Player (string newName, int newScore)
        {
            Name = newName;
            Score = newScore;
        }
    }
        
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.B1Leetcode
{
    public class Q2410MatchPlayersCoaches
    {
        public int MatchPlayersAndTrainers(int[] players, int[] trainers)
        {
            //I know what I did here and it is not good!
            int playersMatched = 0;
            Array.Sort(players);
            Array.Sort(trainers);
            int playerIndex = 0;
            int coachIndex = 0;

            while (playerIndex < players.Length && coachIndex < trainers.Length)
            {
                if (players[playerIndex] <= trainers[coachIndex])
                {
                    playersMatched++;
                    playerIndex++;
                    coachIndex++;
                }
                else
                {
                    coachIndex++;
                }
            }

            return playersMatched;
        }
    }
}

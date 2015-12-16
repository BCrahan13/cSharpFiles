using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01TestHockeyPlayer
{
    class HockeyPlayer
    {
        private string playerName;
        private int jerseyNumber;
        private int goalsScored;

        public string PlayerName {
            get
            {
                return playerName;
            }
            set
            {
                playerName = value;
            }
        }
        public int JerseyNumber {
            get
            {
                return jerseyNumber;
            }
            set
            {
                jerseyNumber = value;
            }
        }
        public int GoalsScored {
            get
            {
                return goalsScored;
            }
            set
            {
                goalsScored = value;
            }
        }

        public HockeyPlayer()
        {
            playerName = "";
            jerseyNumber = 0;
            goalsScored = 0;
        }
        public HockeyPlayer(string playerName, int jerseyNumber, int goalsScored)
        {
            this.playerName = playerName;
            this.jerseyNumber = jerseyNumber;
            this.goalsScored = goalsScored;
        }

    }
}

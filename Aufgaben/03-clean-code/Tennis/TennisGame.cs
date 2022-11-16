using System.Net.Sockets;
using static System.Formats.Asn1.AsnWriter;

namespace Tennis
{
    public class TennisGameManager
    {
        private int p1Point;
        private int p2Point;
        private string p1Result;
        private string p2Result;
        private string playerName1;
        private string playerName2;

        public TennisGameManager(string playerName1, string playerName2)
        {
            this.playerName1 = playerName1;
            this.playerName2 = playerName2;
        }

        public string Score_Getter()
        {
            var score = "";
            
            // when both have same points and game smaller than three
            if (p1Point == p2Point && p1Point < 3){
                switch (p1Point)
                {
                    case 0:
                        score = "Love";
                        break;
                    case 1:
                        score = "Fifteen";
                        break;
                    case 2:
                        score = "Thirty";
                        break;
                }
                
                // do we need this?
                //if (p1point == 3)
                //    s = "Forty";
                score += "-All";
            }

            if (p1Point == p2Point && p1Point > 2)
            {
                score = "Deuce";
            }

            if (p1Point > 0 && p2Point == 0)
            {
                switch (p1Point)
                {
                    case 1:
                        p1Result = "Fifteen";
                        break;
                    case 2:
                        p1Result = "Thirty";
                        break;
                    case 3:
                        p1Result = "Forty";
                        break;
                }

                p2Result = "Love";
                score = p1Result + "-" + p2Result;
            }
            
            if (p2Point > 0 && p1Point == 0)
            {
                switch (p2Point)
                {
                    case 1:
                        p2Result = "Fifteen";
                        break;
                    case 2:
                        p2Result = "Thirty";
                        break;
                    case 3:
                        p2Result = "Forty";
                        break;
                }

                p1Result = "Love";
                score = p1Result + "-" + p2Result;
            }
            
            if (p1Point > p2Point && p1Point < 4)
            {
                switch (p1Point)
                {
                    case 1:
                        p1Result = "Fifteen";
                        break;
                    case 2:
                        p1Result = "Thirty";
                        break;
                    case 3:
                        p1Result = "Forty";
                        break;
                }
                
                score = p1Result + "-" + p2Result;
            }



            if (p2Point > p1Point && p2Point < 4)
            {
                switch (p2Point)
                {
                    case 1:
                        p2Result = "Fifteen";
                        break;
                    case 2:
                        p2Result = "Thirty";
                        break;
                    case 3:
                        p2Result = "Forty";
                        break;
                }
                
                score = p1Result + "-" + p2Result;
            }

            if (p1Point > p2Point && p2Point >= 3)
            {
                score = "Advantage Player 1";
            }

            if (p2Point > p1Point && p1Point >= 3)
            {
                score = "Advantage Player 2";
            }

            score = returnWinForPlayer(score);
            
            return score;
        }

        private string returnWinForPlayer(string unfinishedScore)
        {
            if (p1Point >= 4 && p2Point >= 0 && (p1Point - p2Point) >= 2)
            {
                return "Win for Player 1";
            }
            else if (p2Point >= 4 && p1Point >= 0 && (p2Point - p1Point) >= 2)
            {
                return "Win for Player 2";
            }

            return unfinishedScore;
        }

        public void SetPlayer1Score(int number)
        {
            for (int i = 0; i < number; i++)
            {
                p1Point++;
            }
        }

        public void SetP2Score(int number)
        {
            for (var i = 0; i < number; i++)
            {
                p2Point++;
            }
        }

        public void WonPoint(string tennisPlayer)
        {
            if (tennisPlayer == "player1")
            {
                p1Point++;
            }
            else
            {
                p2Point++;
            }
        }

    }
}


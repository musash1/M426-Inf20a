using System.Net.Sockets;
using static System.Formats.Asn1.AsnWriter;

namespace Tennis
{
    public class TennisGameManager
    {
        private int _p1Point;
        private int _p2Point;
        private string _p1Result;
        private string _p2Result;
        private string _playerName1;
        private string _playerName2;

        public TennisGameManager(string playerName1, string playerName2)
        {
            this._playerName1 = playerName1;
            this._playerName2 = playerName2;
        }

        public string Score_Getter()
        {
            var score = "";
            
            // when both have same points and game smaller than three
            if (_p1Point == _p2Point && _p1Point < 3){
                switch (_p1Point)
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

            if (_p1Point == _p2Point && _p1Point > 2)
            {
                score = "Deuce";
            }

            if (_p1Point > 0 && _p2Point == 0)
            {
                switch (_p1Point)
                {
                    case 1:
                        _p1Result = "Fifteen";
                        break;
                    case 2:
                        _p1Result = "Thirty";
                        break;
                    case 3:
                        _p1Result = "Forty";
                        break;
                }

                _p2Result = "Love";
                score = _p1Result + "-" + _p2Result;
            }
            
            if (_p2Point > 0 && _p1Point == 0)
            {
                switch (_p2Point)
                {
                    case 1:
                        _p2Result = "Fifteen";
                        break;
                    case 2:
                        _p2Result = "Thirty";
                        break;
                    case 3:
                        _p2Result = "Forty";
                        break;
                }

                _p1Result = "Love";
                score = _p1Result + "-" + _p2Result;
            }
            
            if (_p1Point > _p2Point && _p1Point < 4)
            {
                switch (_p1Point)
                {
                    case 1:
                        _p1Result = "Fifteen";
                        break;
                    case 2:
                        _p1Result = "Thirty";
                        break;
                    case 3:
                        _p1Result = "Forty";
                        break;
                }
                
                score = _p1Result + "-" + _p2Result;
            }



            if (_p2Point > _p1Point && _p2Point < 4)
            {
                switch (_p2Point)
                {
                    case 1:
                        _p2Result = "Fifteen";
                        break;
                    case 2:
                        _p2Result = "Thirty";
                        break;
                    case 3:
                        _p2Result = "Forty";
                        break;
                }
                
                score = _p1Result + "-" + _p2Result;
            }

            if (_p1Point > _p2Point && _p2Point >= 3)
            {
                score = "Advantage Player 1";
            }

            if (_p2Point > _p1Point && _p1Point >= 3)
            {
                score = "Advantage Player 2";
            }

            score = ReturnWinForPlayer(score);
            
            return score;
        }

        private string ReturnWinForPlayer(string unfinishedScore)
        {
            if (_p1Point >= 4 && _p2Point >= 0 && (_p1Point - _p2Point) >= 2)
            {
                return "Win for Player 1";
            }
            else if (_p2Point >= 4 && _p1Point >= 0 && (_p2Point - _p1Point) >= 2)
            {
                return "Win for Player 2";
            }

            return unfinishedScore;
        }

        public void WonPoint(string tennisPlayer)
        {
            if (tennisPlayer == "player1")
            {
                _p1Point++;
            }
            else
            {
                _p2Point++;
            }
        }

    }
}


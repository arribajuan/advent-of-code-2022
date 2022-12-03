using System;

namespace AOC2022.Day2.RPS
{
	public class ElfStrategyGuide
	{
        public static List<Round> Decrypt(List<string> encryptedGuide)
        {
            List<Round> decryptedGuide = new List<Round>();

            foreach(string encryptedRound in encryptedGuide)
            {
                Round decryptedRound = new Round();

                string encryptedOpponentHand = encryptedRound.Substring(0, 1);
                switch (encryptedOpponentHand)
                {
                    case "A":
                        decryptedRound.OpponentHand = Enumerations.Hand.Rock;
                        break;
                    case "B":
                        decryptedRound.OpponentHand = Enumerations.Hand.Paper;
                        break;
                    case "C":
                        decryptedRound.OpponentHand = Enumerations.Hand.Scissor;
                        break;
                }

                string encryptedPlayerHand = encryptedRound.Substring(2, 1);
                switch (encryptedPlayerHand)
                {
                    case "X":
                        // Player needs to lose
                        if (decryptedRound.OpponentHand == Enumerations.Hand.Rock)
                        {
                            decryptedRound.PlayerHand = Enumerations.Hand.Scissor;
                        }
                        else if (decryptedRound.OpponentHand == Enumerations.Hand.Paper)
                        {
                            decryptedRound.PlayerHand = Enumerations.Hand.Rock;
                        }
                        else
                        {
                            decryptedRound.PlayerHand = Enumerations.Hand.Paper;
                        }
                        break;
                    case "Y":
                        // Need to tie
                        decryptedRound.PlayerHand = decryptedRound.OpponentHand;
                        break;
                    case "Z":
                        // Player needs to win
                        if (decryptedRound.OpponentHand == Enumerations.Hand.Rock)
                        {
                            decryptedRound.PlayerHand = Enumerations.Hand.Paper;
                        }
                        else if (decryptedRound.OpponentHand == Enumerations.Hand.Paper)
                        {
                            decryptedRound.PlayerHand = Enumerations.Hand.Scissor;
                        }
                        else
                        {
                            decryptedRound.PlayerHand = Enumerations.Hand.Rock;
                        }
                        break;
                }

                decryptedGuide.Add(decryptedRound);
            }

            return decryptedGuide;
        }

        public static List<Round> DecryptStar1(List<string> encryptedGuide)
        {
            List<Round> decryptedGuide = new List<Round>();

            foreach (string encryptedRound in encryptedGuide)
            {
                Round decryptedRound = new Round();

                string encryptedOpponentHand = encryptedRound.Substring(0, 1);
                switch (encryptedOpponentHand)
                {
                    case "A":
                        decryptedRound.OpponentHand = Enumerations.Hand.Rock;
                        break;
                    case "B":
                        decryptedRound.OpponentHand = Enumerations.Hand.Paper;
                        break;
                    case "C":
                        decryptedRound.OpponentHand = Enumerations.Hand.Scissor;
                        break;
                }

                string encryptedPlayerHand = encryptedRound.Substring(2, 1);
                switch (encryptedPlayerHand)
                {
                    case "X":
                        decryptedRound.PlayerHand = Enumerations.Hand.Rock;
                        break;
                    case "Y":
                        decryptedRound.PlayerHand = Enumerations.Hand.Paper;
                        break;
                    case "Z":
                        decryptedRound.PlayerHand = Enumerations.Hand.Scissor;
                        break;
                }

                decryptedGuide.Add(decryptedRound);
            }

            return decryptedGuide;
        }
    }
}


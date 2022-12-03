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


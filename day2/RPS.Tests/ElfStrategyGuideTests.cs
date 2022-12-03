using System;
using System.Data.Common;

namespace AOC2022.Day2.RPS.Tests
{
	public class ElfStrategyGuideTests
	{
        [Theory] 
        [InlineData("A", Enumerations.Hand.Rock, "X", Enumerations.Hand.Scissor)]
        [InlineData("B", Enumerations.Hand.Paper, "Y", Enumerations.Hand.Paper)]
        [InlineData("C", Enumerations.Hand.Scissor, "Z", Enumerations.Hand.Rock)]
        public void DecryptStrategyGuideRounds(string encryptedOpponentHand, Enumerations.Hand opponentHand, string encryptedPlayerHand, Enumerations.Hand playerHand)
        {
            List<string> encryptedGuide = new List<string>();
            encryptedGuide.Add($"{encryptedOpponentHand} {encryptedPlayerHand}");
            List<Round> decryptedGuide = ElfStrategyGuide.Decrypt(encryptedGuide);

            Assert.NotEmpty(decryptedGuide);
            Assert.Equal(opponentHand, decryptedGuide[0].OpponentHand);
            Assert.Equal(playerHand, decryptedGuide[0].PlayerHand);
        }

        /*
        Star 1
        [Theory]
        [InlineData("A", Enumerations.Hand.Rock, "X", Enumerations.Hand.Rock)]
        [InlineData("B", Enumerations.Hand.Paper, "Y", Enumerations.Hand.Paper)]
        [InlineData("C", Enumerations.Hand.Scissor, "Z", Enumerations.Hand.Scissor)]
        public void DecryptStrategyGuideRounds(string encryptedOpponentHand, Enumerations.Hand opponentHand, string encryptedPlayerHand, Enumerations.Hand playerHand)
        {
            List<string> encryptedGuide = new List<string>();
            encryptedGuide.Add($"{encryptedOpponentHand} {encryptedPlayerHand}");
            List<Round> decryptedGuide = ElfStrategyGuide.Decrypt(encryptedGuide);

            Assert.NotEmpty(decryptedGuide);
            Assert.Equal(opponentHand, decryptedGuide[0].OpponentHand);
            Assert.Equal(playerHand, decryptedGuide[0].PlayerHand);
        }
        */
    }
}


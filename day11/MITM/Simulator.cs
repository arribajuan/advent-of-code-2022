using System.Diagnostics;

namespace AOC2022.Day11.MITM;

public class Simulator
{
    public List<Monkey> Monkeys { get; set; }

    public int TotalMonkeyBusiness => CalculateTotalMonkeyBusiness();

    public Simulator(List<Monkey> initialMonkeys)
    {
        Monkeys = initialMonkeys;
    }

    public void PlayRound()
    {
        foreach (Monkey monkey in Monkeys)
        {
            Debug.WriteLine($"Monkey {monkey.MonkeyNumber}:");

            foreach (int initialWorryLevel in monkey.ItemsHeld.ToArray())
            {
                Debug.WriteLine($" - Monkey inspects an item with a worry level of {initialWorryLevel}.");
                
                #region Calcualte new worry level 
                
                int modifyValueBy = 0;
                if (monkey.OperationValueType == "old")
                {
                    modifyValueBy = initialWorryLevel;
                }
                else
                {
                    modifyValueBy = monkey.OperationValue;
                }
                
                int newWorryLevel = 0;
                if (monkey.OperationName == "*")
                {
                    newWorryLevel = initialWorryLevel * modifyValueBy;
                    Debug.WriteLine($"    - Worry level is multiplied by {modifyValueBy} to {newWorryLevel}.");
                    
                }
                else if (monkey.OperationName == "+")
                {
                    newWorryLevel = initialWorryLevel + modifyValueBy;
                    Debug.WriteLine($"    - Worry level is increased by {modifyValueBy} to {newWorryLevel}.");
                }

                int finalWorryLevel = newWorryLevel / 3;
                Debug.WriteLine($"    - Monkey gets bored with item. Worry level is divided by 3 to {finalWorryLevel}.");
                
                #endregion
                
                #region Throw item to another monkey

                if (finalWorryLevel % monkey.TestValue == 0)
                {
                    Debug.WriteLine($"    - Current worry level is divisible by {monkey.TestValue}.");
                    Monkeys[monkey.TestTargetMonkeyIfTrue].ItemsHeld.Add(finalWorryLevel);
                    Debug.WriteLine($"    - Item with worry level {finalWorryLevel} is thrown to monkey {monkey.TestTargetMonkeyIfTrue}.");
                }
                else
                {
                    Debug.WriteLine($"    - Current worry level is not divisible by {monkey.TestValue}.");
                    Monkeys[monkey.TestTargetMonkeyIfFalse].ItemsHeld.Add(finalWorryLevel);
                    Debug.WriteLine($"    - Item with worry level {finalWorryLevel} is thrown to monkey {monkey.TestTargetMonkeyIfFalse}.");
                }

                monkey.Interactions++;
                
                #endregion
                
                monkey.ItemsHeld.Remove(initialWorryLevel);
            }
        }
    }

    public void PlayRounds(int roundsToPlay)
    {
        for (int i = 0; i < roundsToPlay; i++)
        {
            PlayRound();
        }
    }

    private int CalculateTotalMonkeyBusiness()
    {
        var topMonkeys =
                (from m in Monkeys
                    orderby m.Interactions descending
                    select m.Interactions
                ).Take(2);

        int result = 1;
        foreach (int monkeyInteractionTotal in topMonkeys)
        {
            result *= monkeyInteractionTotal;
        }
        
        return result;
    }
}
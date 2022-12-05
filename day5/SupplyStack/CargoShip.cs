using System;
using System.Collections;

namespace AOC2022.Day5.SupplyStack
{
    public class CargoShip
	{
        /*
        Supplies are stored in stacks of marked crates
        The ship has a giant cargo crane capable of moving crates between stacks.
        After the crates are rearranged, the desired crates will be at the top of each stack.

        The Elves don't want to interrupt the crane operator during this delicate procedure,
        but they forgot to ask her which crate will end up where,
        and they want to be ready to unload them as soon as possible so they can embark.

        They do, however, have a drawing of the starting stacks of crates and
        the rearrangement procedure (your puzzle input). For example:

            [D]    
        [N] [C]    
        [Z] [M] [P]
         1   2   3 

        move 1 from 2 to 1
        move 3 from 1 to 3
        move 2 from 2 to 1
        move 1 from 1 to 2
        */

        public CargoShipSupplies ShipSupplies { get; private set; }

        public CargoShip(string[] initialSuppliesStrings)
		{
            this.ShipSupplies = new CargoShipSupplies(initialSuppliesStrings);
		}

        public void MoveCrates(CraneInstruction craneInstruction)
        {
            for (int i = 0; i < craneInstruction.Amount; i++)
            {
                //int itemToMove = this.ShipSupplies.StackList[craneInstruction.SourceStackNumber - 1].Pop();
                //this.ShipSupplies.StackList[craneInstruction.DestinationStackNumber - 1].Push(itemToMove);
            }
        }
    }
}


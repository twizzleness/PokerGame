using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poker
{
    class Player
    {
        string Name { get; set; }
        Hand Hand { get; set; }

        Player(string name, Hand hand)
        {
            Name = name;
            Hand = hand;
        }
    }
}

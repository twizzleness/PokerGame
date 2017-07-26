using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poker
{
    class Hand
    {
        public List<Card> Cards { get; set; }
        public IRanking Rank { get; set; }

        Hand(List<Card> cards, IRanking rank)
        {
            Cards = cards;
            Rank = rank;
        }
    }
}

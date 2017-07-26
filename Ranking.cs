using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace poker
{
    public interface IRanking
    {
        Card HighCard { get; set; }
        Rank Rank { get; set; }
    }

    public class Flush : IRanking
    {
        public Card HighCard { get; set; }
        public Rank Rank { get; set; }

        public Flush(Card highCard)
        {
            HighCard = highCard;
            Rank = Rank.FLUSH;
        }

        static public bool IsFlush(List<Card> cards)
        {
            var currentSuit = cards.ElementAt(0).Suit;
            foreach(var card in cards.Skip(1))
            {
                if (currentSuit != card.Suit)
                    return false;
            }
            return true;
        }
    }
}

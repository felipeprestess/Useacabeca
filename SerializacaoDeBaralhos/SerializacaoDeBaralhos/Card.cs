﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacaoDeBaralhos
{
    [Serializable]
    partial class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }

        public Card(Suits Suit, Values Value)
        {
            this.Suit = Suit;
            this.Value = Value;
        }

        public string Name { get { return Value.ToString() + " of " + Suit.ToString(); } }

        public override string ToString()
        {
            return Name;
        }

        public static string Plural(Values value)
        {
            if (value == Values.Six)
                return "sixes";
            else
                return value.ToString() + "s";
        }
    }
    [Serializable]
    enum Values
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
    }
    [Serializable]
    enum Suits
    {
        Spades,
        Clubs,
        Diamonds,
        Hearts,
    }
}

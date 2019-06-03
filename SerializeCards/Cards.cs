﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeCards
{
    [Serializable]
    class Cards // : IComparable<Cards>, IComparer<Cards>
    {
        public Values Value { get; set; }
        public Suits Suit { get; set; }
        public string Name { get => $"{Suit} of {Value}"; }

        public Cards(Suits suit, Values value)
        {
            Value = value;
            Suit = suit;
        }

        public static bool DoesCardMatch(Cards cardToCheck, Suits suit)
        {
            if (cardToCheck.Suit == suit)
                return true;

            return false;
        }

        public static bool DoesCardMatch(Cards cardToCheck, Values value)
        {
            if (cardToCheck.Value == value)
                return true;

            return false;
        }

        //public int CompareTo(Cards card)
        //{
        //    if (this.Suit > card.Suit)
        //        return 1;
        //    if (this.Suit < card.Suit)
        //        return -1;

        //    if (this.Value > card.Value)
        //        return 1;
        //    if (this.Value < card.Value)
        //        return -1;

        //    return 0;

        //}



        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }

   
    }



    
}

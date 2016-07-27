using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TojeTedaGoll.Models;

namespace TojeTedaGoll.Data
{
    public class GiftRepository
    {
        private static Gift[] _gifts = new Gift[]
        {
            new Gift()
            {
                Id = 1,
                Name = "Nadobi",
                ShortDescription = "Nadobi od firmy Tescoma",
                FullDescrition = "Lorem ipsum dolor sit amet",
            },

            new Gift()
            {
                Id = 2,
                Name = "Matrace",
                ShortDescription = "Matrace z IKEI",
                FullDescrition = "Lorem ipsum dolor sit amet",
            },

            new Gift()
            {
                Id = 3,
                Name = "Cash",
                ShortDescription = "Peníze a zase jenom peníze",
                FullDescrition = "Lorem ipsum dolor sit amet",
            }
        };


        public Gift GetGift(int id)
        {
            Gift giftToReturn = null;

            foreach (var gift in _gifts)
            {
                if (gift.Id == id)
                {
                    giftToReturn = gift;
                    break;
                }
            }

            return giftToReturn;
        }
    }
}
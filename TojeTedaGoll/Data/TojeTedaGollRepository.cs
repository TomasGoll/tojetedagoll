using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TojeTedaGoll.Models;

namespace TojeTedaGoll.Data
{
    public class TojeTedaGollRepository
    {
        private static WeddingGift[] _weddingGifts = new WeddingGift[]
        {
            new WeddingGift()
            {
                Id = 1,
                GiftName = "Nádobí",
                ShortDescription = "Nadobi od firmy XY",
                FullDescription = "Lorem Ipsum dolor sit Amer",
                ImagePath = "/Images/nadobi.png"
            },

            new WeddingGift()
            {
                Id = 2,
                GiftName = "Matrace",
                ShortDescription = "Matrace z IKEI",
                FullDescription = "Lorem Ipsum dolor sit Amer",
                ImagePath = "/Images/matrace.png"
            },

            new WeddingGift()
            {
                Id = 3,
                GiftName = "Cash",
                ShortDescription = "Peníze a zase jen peníze, hodně peněz",
                FullDescription = "Lorem Ipsum dolor sit Amer",
                ImagePath = "/Images/cash.png"
            },

            new WeddingGift()
            {
                Id = 4,
                GiftName = "Cesta kolem sveta",
                ShortDescription = "A kýbl klidu",
                FullDescription = "Lorem Ipsum dolor sit Amer",
                ImagePath = "/Images/cesta-kolem-sveta.png"
            },

            new WeddingGift()
            {
                Id = 5,
                GiftName = "Cesta kolem sveta",
                ShortDescription = "A kýbl klidu",
                FullDescription = "Lorem Ipsum dolor sit Amer",
                ImagePath = "/Images/cesta-kolem-sveta.png"
            },

            new WeddingGift()
            {
                Id = 6,
                GiftName = "Cesta kolem sveta",
                ShortDescription = "A kýbl klidu",
                FullDescription = "Lorem Ipsum dolor sit Amer",
                ImagePath = "/Images/cesta-kolem-sveta.png"
            }
        };

        public WeddingGift[] GetWeddingGifts()
        {
            return _weddingGifts;
        }

        public WeddingGift GetWeddingGift(int id)
        {
            WeddingGift weddingGiftToReturn = null;

            foreach (var weddingGift in _weddingGifts)
            {
                if (weddingGift.Id == id)
                {
                    weddingGiftToReturn = weddingGift;
                    break;
                }
            }

            return weddingGiftToReturn;
        }
    }
}
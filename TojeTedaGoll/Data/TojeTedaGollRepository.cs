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
                GiftName = "Nadobi",
                ShortDescription = "Nadobi od firmy XY",
                FullDescription = "Lorem Ipsum dolor sit Amer",
            },

            new WeddingGift()
            {
                Id = 2,
                GiftName = "Matrace",
                ShortDescription = "Matrace z IKEI",
                FullDescription = "Lorem Ipsum dolor sit Amer",
            },

            new WeddingGift()
            {
                Id = 3,
                GiftName = "Cash",
                ShortDescription = "Peníze a zase jen peníze, hodně peněz",
                FullDescription = "Lorem Ipsum dolor sit Amer",
            }
        };

        public WeddingGift[] GetWeddingGifts()
        {
            return _weddingGifts;
        }
    }
}
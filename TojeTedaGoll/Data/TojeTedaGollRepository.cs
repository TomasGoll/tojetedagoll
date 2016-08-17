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
                GiftName = "Wok s pokličkou",
                ShortDescription = "Čínská pánev wok s pokličkou",
                FullDescription = "Nemusí být přímo z Číny :). Jediným kritériem je ona poklička. Protože bez ní se to fakt nedá.",
                ImagePath = "/Images/wok.jpg"
            },

            new WeddingGift()
            {
                Id = 2,
                GiftName = "Matrace",
                ShortDescription = "Finanční příspěvek na nové matrace",
                FullDescription = "Jelikož naše stávající dosluhují, rozhodli jsme se touto formou požádat o příspěvek na nové.",
                ImagePath = "/Images/matrace.png"
            },

            new WeddingGift()
            {
                Id = 3,
                GiftName = "Cash",
                ShortDescription = "Peníze a zase jen peníze, hodně peněz",
                FullDescription = "Jak se to jen píše...aha! Přijmeme darem jakýkoli finanční obnos. Výtežek z této akce půjde na dobročinné účely.",
                ImagePath = "/Images/cash.png"
            },

            new WeddingGift()
            {
                Id = 4,
                GiftName = "Domácí pekárna",
                ShortDescription = "Protože domácí chlebík je nej!",
                FullDescription = "Ánina vysněná domácí pekárnička. Prý žádné preference ohledně značky a funkcí.",
                ImagePath = "/Images/pekarna.jpg"
            },

            new WeddingGift()
            {
                Id = 5,
                GiftName = "Kajtra",
                ShortDescription = "Náá hradě Okoři...",
                FullDescription = "...svěěětla už nehoří...",
                ImagePath = "/Images/kajtra.jpg"
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
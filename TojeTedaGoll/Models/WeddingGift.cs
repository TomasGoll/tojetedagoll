using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TojeTedaGoll.Models
{
    public class WeddingGift
    {
        public int Id { get; set; }
        public string GiftName { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public string ImagePath { get; set; }
        public bool Chosen { get; set; }

        public string GetGiftName
        {
            get
            {
                return GiftName;
            }
        }

        public string GiftImageName
        {
            get
            {
                return GiftName.Replace(" ", "-").ToLower() + ".png";
            }
        }
    }
}
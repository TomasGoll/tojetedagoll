using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TojeTedaGoll.Models
{
    public class Gift
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescrition { get; set; }

        public string ImageFileName
        {
            get
            {
                return Name.Replace(" ", "-").ToLower() + ".png";
            }
        }
    }
}
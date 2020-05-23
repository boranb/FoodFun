using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodFun.Models
{
    public class About
    {
        [StringLength(200)]
        public string Address { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(80)]
        public string Mail { get; set; }
        [StringLength(100)]
        public string Hours { get; set; }
        [StringLength(100)]
        public string FooterInfo { get; set; }
        [StringLength(50)]
        public string AboutTitle { get; set; }
        [StringLength(1000)]
        public string AboutContent { get; set; }
        public string MapsLink { get; set; }
        public string LogoPhotoPath { get; set; }
        [StringLength(50)]
        public string LongNotificationTitle { get; set; }
        [StringLength(300)]
        public string LongNotificationContent { get; set; }
        [StringLength(50)]
        public string ShortNotificationTitle { get; set; }
        [StringLength(100)]
        public string ShortNotificationContent { get; set; }
    }
}
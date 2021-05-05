using SEDC.CSharpAdv.VideoRental.Data.BaseModels;
using System;

namespace SEDC.CSharpAdv.VideoRental.Data.Models
{
    public class User : BaseEntity
    {
        public string FullName { get; set; }
        // card number is used as a username
        public int CardNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsSubscriptionExpired { get; set; }
        public DateTime SubscriptionExpireTime { get; set; }
    }
}

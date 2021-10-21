using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class ShopEcomAuto
    {
        public int Id { get; set; }
        public int? ShopId { get; set; }
        public string MessageShopee { get; set; }
        public string OrderStatus { get; set; }
        public int? Stars { get; set; }
        public bool? IsActiveShopee { get; set; }
        public int AccountId { get; set; }
        public string MessageZalo { get; set; }
        public bool? IsActiveZalo { get; set; }
        public string MessageSms { get; set; }
        public bool? IsActiveSms { get; set; }
        public int? ShopIdZalo { get; set; }
        public bool? InviteZalo { get; set; }
        public bool? ShopIdSms { get; set; }
        public int? ShopIdFacebook { get; set; }
        public bool? InviteFacebook { get; set; }
        public string MessageFacebook { get; set; }
        public bool? IsActiveFacebook { get; set; }
        public string LinkMedia { get; set; }
        public int? DeleyTime { get; set; }
        public string DeleyType { get; set; }
        public byte? Type { get; set; }
    }
}

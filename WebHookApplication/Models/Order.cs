using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderProducts = new HashSet<OrderProduct>();
            SmsSendingContacts = new HashSet<SmsSendingContact>();
            TagTables = new HashSet<TagTable>();
        }

        public int Id { get; set; }
        public string OrderCode { get; set; }
        public string StatusOderShopee { get; set; }
        public string ContactShopeeCode { get; set; }
        public string StatusRefundShopee { get; set; }
        public int? ContactId { get; set; }
        public DateTime? DateCompletedPayment { get; set; }
        public DateTime? DateOrder { get; set; }
        public string OrderSource { get; set; }
        public decimal? DiscountCash { get; set; }
        public double? DiscountPercent { get; set; }
        public decimal? OrderPay { get; set; }
        public decimal? ShipPay { get; set; }
        public decimal? OrderSumPay { get; set; }
        public string ShipUnit { get; set; }
        public string ShipCode { get; set; }
        public string ShipType { get; set; }
        public int? ShipStaffId { get; set; }
        public string PayType { get; set; }
        public string Describe { get; set; }
        public string ProductListShopee { get; set; }
        public DateTime? DateShipExpected { get; set; }
        public DateTime? DateShip { get; set; }
        public DateTime? DateShipCompleted { get; set; }
        public string ContactComment { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? StaffModifyId { get; set; }
        public DateTime? DateModify { get; set; }
        public int? StaffCreateId { get; set; }
        public int? StaffOwnerId { get; set; }
        public string ContactNameDelivery { get; set; }
        public string ContactMobileDelivery { get; set; }
        public string ContactAdressDelivery { get; set; }
        public string ContactCountryDelivery { get; set; }
        public string ContactCityDelivery { get; set; }
        public string ContactDistrictDelivery { get; set; }
        public string PostCode { get; set; }
        public string OrderType { get; set; }
        public int? AccountId { get; set; }
        public string VnPostStatus { get; set; }
        public string OrderStatusGeneral { get; set; }
        public string LinkInboxPage { get; set; }
        public string TagNameList { get; set; }
        public string TagIdStringList { get; set; }
        public int? ShopId { get; set; }
        public string LogisticsStatus { get; set; }
        public string TrackingLogisticsStatus { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual staff StaffOwner { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
        public virtual ICollection<SmsSendingContact> SmsSendingContacts { get; set; }
        public virtual ICollection<TagTable> TagTables { get; set; }
    }
}

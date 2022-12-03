﻿using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Ecommerce.Orders
{
    public class Order : FullAuditedAggregateRoot<Guid>
    {
        public string Code { get; set; }
        public OrderStatus Status { get; set; }
        public ShippingMethod ShippingMethod { get; set; }
        public double ShippingFee { get; set; }
        public double Tax { get; set; }
        public double Total { get; set; }
        public double SubTotal { get; set; }
        public double Discount { get; set; }
        public double GrandTotal { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerAddress { get; set; }
        public Guid? CustomerUserId { get; set; }
    }
}

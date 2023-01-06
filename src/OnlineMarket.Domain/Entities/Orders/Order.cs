﻿using OnlineMarket.Domain.Common;
using OnlineMarket.Domain.Entities.Employees;
using OnlineMarket.Domain.Entities.Users;
using OnlineMarket.Domain.Enums;

namespace OnlineMarket.Domain.Entities.Orders;
public class Order : Auditable
{
    public long UserId { get; set; }
    public virtual User User { get; set; } = default!;

    public long OperatorId { get; set; }
    public virtual Operator Operator { get; set; } = default!;

    public long DeliverId { get; set; }
    public virtual Deliver Deliver { get; set; } = default!;

    public virtual Location Location { get; set; } = default!;

    public double TotalSum { get; set; }

    public PaymentType PaymentType { get; set; }

    public OrderStatus OrderStatus { get; set; }

    public DateTime? DeliveredAt { get; set; }
}

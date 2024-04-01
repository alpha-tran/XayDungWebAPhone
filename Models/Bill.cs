using System;
using System.Collections.Generic;

namespace XayDungWebAphone.Models;

public partial class Bill
{
    public int IdBill { get; set; }

    public int? TotalAmount { get; set; }

    public int IdOrder { get; set; }

    public virtual Order IdOrderNavigation { get; set; } = null!;

    public virtual ICollection<OrderDetal> OrderDetals { get; set; } = new List<OrderDetal>();
}

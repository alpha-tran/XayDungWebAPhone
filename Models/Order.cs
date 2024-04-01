using System;
using System.Collections.Generic;

namespace XayDungWebAphone.Models;

public partial class Order
{
    public int IdOrder { get; set; }

    public DateOnly OrderDate { get; set; }

    public int IdClient { get; set; }

    public int IdUser { get; set; }

    public int IdPay { get; set; }

    public int IdOrderDetals { get; set; }

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    public virtual Client IdClientNavigation { get; set; } = null!;

    public virtual OrderDetal IdOrderDetalsNavigation { get; set; } = null!;

    public virtual Pay IdPayNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}

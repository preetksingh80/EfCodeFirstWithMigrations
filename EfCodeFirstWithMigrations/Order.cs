using System;
using System.Collections.Generic;
using EfCodeFirstWithMigrations.Enums;

namespace EfCodeFirstWithMigrations
{
  public class Order
  {
    private ICollection<LineItem> _lineItems;

    public Order()
    {
      _lineItems = new List<LineItem>();
    }

    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    
    public OrderSource OrderSource { get; set; }
    public int CustomerId { get; set; }

    public Customer Customer { get; set; }

    public ICollection<LineItem> LineItems
    {
      get { return _lineItems; }
      set { _lineItems = value; }
    }
  }
}
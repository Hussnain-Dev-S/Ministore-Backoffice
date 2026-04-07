using System;
using App.core.Models;
using System.Collections.Generic;
using System.Text;
using App.core.Utilities;

namespace App.core.Contracts
{
    public interface IOrderService
    {
        public List<Order> GetAll();
        public Order GetbyId(string id);
        public void Add(Order order);

        public void Update(Order order);
        public void Delete(string id);

        public List<Order> GetByCustomerId(string customerid);
        public List<Order> GetByStatus(OrderStatusEnum status);
    }
}

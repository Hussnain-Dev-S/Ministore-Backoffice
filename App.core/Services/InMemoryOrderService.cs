using App.core.Contracts;
using App.core.Models;
using App.core.Utilities;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace App.core.Services
{
    public class InMemoryOrderService : IOrderService
    {
        private List<Order> _orders;
        public InMemoryOrderService()
        {
            _orders = new List<Order>();
        }
        List<Order> IOrderService.GetAll()
        {
            return _orders.ToList();
        }
        void IOrderService.Add(Order order)
        {
            if (order == null)
                throw new ArgumentNullException("Order is null");
            _orders.Add(order);
        }

        void IOrderService.Delete(string id)
        {
            _orders.RemoveAll(order => order.Id == id);
        }
        Order IOrderService.GetbyId(string id)
        {
            return _orders.FirstOrDefault(order => order.Id == id);
        }

        List<Order> IOrderService.GetByStatus(OrderStatusEnum status)
        {
            return _orders.Where(order => order.Status == status).ToList();
        }
        List<Order> IOrderService.GetByCustomerId(string customerid)
        {
            return _orders.Where(order => order.CustomerId == customerid).ToList();
        }

        void IOrderService.Update(Order order)
        {
            var existing = _orders.FirstOrDefault(o => o.Id == order.Id);
            if (existing == null)
            {
                throw new Exception($"Order with Id={order.Id} not found");
            }
            existing.CustomerId = order.CustomerId;
            existing.CustomerName = order.CustomerName;
            existing.OrderDate = order.OrderDate;
            existing.Status = order.Status;
            existing.PaymentMethod = order.PaymentMethod;
            existing.Items = order.Items;
        }
    }
}
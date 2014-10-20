﻿using System.Collections.Generic;

namespace Northwind
{
    internal interface IRepository
    {
        /// <summary>
        ///     Returns all products.
        /// </summary>
        /// <returns>Returns all of the Products in the repository</returns>
        IEnumerable<Product> Products();

        /// <summary>
        ///     Returns all categories.
        /// </summary>
        /// <returns>Returns all of the Categories in the repository.</returns>
        IEnumerable<Category> Categories();


        /// <summary>
        ///     Returns all orders.
        /// </summary>
        /// <returns>Returns all of the Orders in the repository.</returns>
        IEnumerable<Order> Orders();

        /// <summary>
        ///     Add an order to the repository.
        ///     Must add order id (max id + 1) to the order before storing it.
        /// </summary>
        /// <param name="order">The Order to add to the repository</param>
        void CreateOrder(Order order);
    }
}
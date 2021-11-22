using EFDataAccessLibrary.DataAccess;
using EFDataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccessLibrary.DataProcessors
{
    public static class OrderProcessor
    {

        /// <summary>
        /// SVDM - Statis method to Create Order and apply discount if needed
        /// </summary>
        /// <param name="order"></param>
        /// <param name="_context"></param>
        /// <returns>Order</returns>
        public static Order CreateOrder(Order order, DemoDataContext _context)
        {
            try
            {
                int discount = 0;
                decimal total = 0;
                List<int> bundleIDs = new List<int>();
                order.Id = 0;

                //SVDM - Loop through items in basket to create total
                foreach (var item in order.Basket.BasketItems)
                {                    
                    // Get List of ID's from Bundles table where this item is part of bundle.
                    var bundleIDsList = _context.BundleItems.Where(b => b.Name == item.Name).Select(i => i.BundlesId).ToList();

                    foreach (var bundleID in bundleIDsList)
                    {
                        var bundleList = _context.BundleItems.Where(bi => bi.BundlesId == bundleID).ToList();

                        //SVDM - Use LINQ join to compare the items in the bundle, to the items in the basket.
                        //       To see if discount will be apply for the items in your basket.
                        var matchedItems = (from x in bundleList
                                            join y in order.Basket.BasketItems
                                            on x.Name equals y.Name
                                            select x).ToList();

                        if (matchedItems.SequenceEqual(bundleList))
                        {
                            discount = _context.Bundles.Where(b => b.Id == bundleID).Select(d => d.Discount).FirstOrDefault();
                            item.Price -= item.Price / 100 * discount;
                            break;
                        }
                    }
                    order.Basket.Total += item.Price;
                }
                
                return order;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool CheckIfDiscountApplied(Order order, Order newOrder)
        {
            if (order.Basket.Total > newOrder.Basket.Total)
            {
                return true;
            }
            return false;
                 
        }
    }
}

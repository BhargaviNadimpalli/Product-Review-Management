using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProductReviewManagement
{
    public class Management
    {
        public readonly DateTime dateTime = new DateTime();

        public void TopRecord(List<ProductReview> productReviews)
        {
            var recordedData = (from products in productReviews
                                orderby products.Rating descending
                                select products).Take(3);

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId : " + list.ProductId + " " + "UserId : " + " " + list.UserId
                   + " " + "Rating : " + list.Rating + " " + "Review : " + list.Review + " " + "IsLike : " + list.IsLike);
            }

        }
    }
}

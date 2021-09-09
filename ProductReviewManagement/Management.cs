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
        public void SelectRecords(List<ProductReview> productReviews)
        {
            var recordedData = from ProductReview in productReviews
                               where (ProductReview.ProductId == 1 || ProductReview.ProductId == 4 || ProductReview.ProductId == 9)
                               && ProductReview.Rating > 3
                               select ProductReview;

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId : " + list.ProductId + " " + "UserId : " + " " + list.UserId
                   + " " + "Rating : " + list.Rating + " " + "Review : " + list.Review + " " + "IsLike : " + list.IsLike);
            }
        }
    }
}

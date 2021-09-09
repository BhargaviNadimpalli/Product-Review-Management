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
        public void RetrieveCountRecords(List<ProductReview> productReviews)
        {
            var recordedData = productReviews.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count() });
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductId + "-----" + list.Count);
            }
        }
        public void RetrieveProductIDAndReview(List<ProductReview> list)
        {
            var recordedData = (from products in list
                                select new { products.ProductId, products.Review });
            foreach (var productReview in recordedData)
            {
                Console.WriteLine("Product ID: " + productReview.ProductId + "\tReviews: " + productReview.Review);
            }
        }
        public void SkipTopFive(List<ProductReview> list)
        {
            var recordedData = (from products in list
                                select products).Skip(5);
            foreach (var productReview in recordedData)
            {
                Console.WriteLine("ProductId : " + productReview.ProductId + " " + "UserId : " + " " + productReview.UserId
                    + " " + "Rating : " + productReview.Rating + " " + "Review : " + productReview.Review + " " + "IsLike : " + productReview.IsLike);

            }
        }
    }
}

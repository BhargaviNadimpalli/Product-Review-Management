using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------");

            List<ProductReview> products = new List<ProductReview>()
            {
                new ProductReview(){ProductId=1, UserId=1, Rating = 5, Review = "Good", IsLike = true},
                new ProductReview(){ProductId=2, UserId=2, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview(){ProductId=3, UserId=1, Rating = 3, Review = "Good", IsLike = true},
                new ProductReview(){ProductId=4, UserId=6, Rating = 2, Review = "Good", IsLike = true},
                new ProductReview(){ProductId=5, UserId=4, Rating = 10, Review = "Good", IsLike = true},
                new ProductReview(){ProductId=6, UserId=4, Rating = 5, Review = "Bad", IsLike = true},
                new ProductReview(){ProductId=7, UserId=3, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview(){ProductId=4, UserId=5, Rating = 3, Review = "Good", IsLike = true},
                new ProductReview(){ProductId=9, UserId=2, Rating = 4, Review = "Bad", IsLike = true},
                new ProductReview(){ProductId=11, UserId=6, Rating = 1, Review = "Good", IsLike = true},
                new ProductReview(){ProductId=11, UserId=7, Rating = 9, Review = "Nice", IsLike = true},
                new ProductReview(){ProductId=12, UserId=2, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview(){ProductId=13, UserId=7, Rating = 3, Review = "Super", IsLike = true},
                new ProductReview(){ProductId=13, UserId=8, Rating = 8, Review = "Good", IsLike = true},
                new ProductReview(){ProductId=15, UserId=9, Rating = 1, Review = "Super", IsLike = true},
                new ProductReview(){ProductId=1, UserId=5, Rating = 5, Review = "Good", IsLike = true},
                new ProductReview(){ProductId=7, UserId=7, Rating = 4, Review = "Bad", IsLike = true},
            };
            //foreach (var list in products)
            //{
            //    Console.WriteLine("ProductId : " + list.ProductId + " " + "UserId : " + " " + list.UserId
            //        + " " + "Rating : " + list.Rating + " " + "Review : " + list.Review + " " + "IsLike : " + list.IsLike);
            //}
            Management management = new Management();
            //management.TopRecord(products);
            management.SelectRecords(products);
        }
    }
}

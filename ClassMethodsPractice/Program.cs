using System;

namespace ClassMethodsPractice
{
    class Comment
    {
        public int CommentId { get; set; }
        public string CommentText { get; set; }
    }
    class Product
    {
        public Product()
        {
            this.ProductId = (new Random()).Next(11111,99999);
            this.Comments = new Comment[3];
        }
        public Product(int productId)
        {
            this.ProductId= productId;
        }

        public Product(int productId, string name, double price, bool isApproved) : this(productId)
        {
            Name = name;
            Price = price;
            IsApproved = isApproved;
        }
    
        public int ProductId { get; set; } 
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsApproved { get; set; }
        public Comment[] Comments { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Comment { CommentId = 1, CommentText = "Nice Phone" };
            var p1 = new Product();

            
            p1.Comments[0] = c1;
            Console.WriteLine(p1.ProductId);
            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.Price);
            Console.WriteLine(p1.IsApproved);
            Console.WriteLine(p1.Comments[0].CommentText);

            Console.WriteLine("********************");

            var p2 = new Product(1234);
            Console.WriteLine(p2.ProductId);
            Console.WriteLine(p2.Name);
            Console.WriteLine(p2.Price);
            Console.WriteLine(p2.IsApproved);

            Console.WriteLine("********************");

            var p3 = new Product(1231,"Iphone13", 21000, true );
            Console.WriteLine(p3.ProductId);
            Console.WriteLine(p3.Name);
            Console.WriteLine(p3.Price);
            Console.WriteLine(p3.IsApproved);
        }
    }
}

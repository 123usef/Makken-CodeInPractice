namespace MakeenPatch03_Day10
{
    internal class Products
    {
        public const double pi = 3.14;
        //static id is a class Member 
        public static int cnt;
        public int ProductId;
        
        public  string Name;
        public string description; 
        public double price;
        public int CountInStock;
        public bool HasDiscount;


        public Products()
        {
            //constructor 
        }
        public Products(string Name , string description , double price , int CountInStock , bool HasDiscount )
        {
            cnt += 1;
            this.ProductId = cnt;
            this.Name = Name;
            this.description = description;
            this.price = price;
            this.CountInStock = CountInStock;
            this.HasDiscount = HasDiscount;
            //Console.WriteLine($"item is added with id {cnt}");
        }
        
        // Instance Method 
        public void PrintDetails()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("| \t \t \t Welcome to admin DashBoard ");
            Console.WriteLine($"Product Id : {this.ProductId}\n|Product Name is {this.Name} \n|Product Description : {this.description}" +
                $"\n| Product price is : {this.price} OMR \n| Product Count in Stock : {this.CountInStock}" +
                $"\n| has Discount : {this.HasDiscount} ");
        }




    }
}

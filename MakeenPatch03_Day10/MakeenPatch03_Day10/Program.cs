namespace MakeenPatch03_Day10
{
    #region struct 
    //struct Point // doesn't Support Inhertance 
    //{
    //    public int X;
    //    public int Y;
    //}
    #endregion

    //Accesse Modifier 
    internal class  Program
    {
        static void Main(string[] args)
        {
            #region 4Pillars for OOP
            //قوالب ل صنع البيانات 
            // Struct  Enum  || Class  InterFace 
            //1- Inhertance || الوراثة  كل ما يمت بصله للوارثة 
            //2- polymorphism || تعدد اشكال الفعل ||overloading || override
            //3- Encapsulation || setter & getter 
            //4-Abstraction || التجريد (افعال لا اقوال
            #endregion
            #region Struct 
            //Console.WriteLine("hello World ");
            //Point p = new Point();
            //p.X = 10;
            //p.Y = 20;
            #endregion
            #region Products Instance 
            // Products products = new Products();
            ////Class Name
            // //Products.
            // //Products.pi

            // products.Name = "Tennis Ball ";
            // products.description = "Description";
            // products.price = 20.0;
            // Console.WriteLine(products.Name);
            //Products products1 = new Products("BBQ grill", "very good BBQ grill for maldiv ", 25.350, 20, false);
            //Products products2 = new Products("BBQ grill", "very good BBQ grill for maldiv ", 25.350, 20, false);
            //Products products3 = new Products("BBQ grill", "very good BBQ grill for maldiv ", 25.350, 20, false);
            //Console.WriteLine($"Product Counts  is {Products.cnt}");
            //console.writeline(products1.productid);
            //console.writeline(products2.productid);
            //console.writeline(products3.productid);
            #endregion

            // Mathematical Constant (Fixed Value) 
            //const double pi = 22/7;

            //pi = 5.3; Will Not Allow any Changes After Decleration and Assignment

            Products products1 = new Products("BBQ grill", "very good BBQ grill for maldiv ", 25.350, 20, false);
            //products1.PrintDetails();
            


            Products products2 = new Products("Tennis Ball", "a very good play on  maldiv beachs ", 22, 10, true);

            Products products3 = new Products("lipstick", "kiko a very high quality lipstick for coubles ", 23.350, 10, false);

            //products2.PrintDetails();
            //products1.PrintDetails();
            //products3.PrintDetails();

            Products[] productItems = {products1 , products2 , products3 };
            foreach (Products item in productItems)
            {
                item.PrintDetails();

            }











        }
    }
}
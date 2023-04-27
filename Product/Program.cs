using System.Collections;

namespace ProductProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime date = DateTime.Now;
            //Console.WriteLine(date);
            //Console.WriteLine(DateTime.Now.ToLongDateString());
            //Console.WriteLine(DateTime.Now.ToShortDateString());
            //date = new DateTime(2022, 3, 11);
            //Console.WriteLine(date);
            //Console.WriteLine(DateTime.Now.ToString("1"));


            //Product product1 = new Product(productCode: "P001", productName: "TShirt",
            //    qtyStock: 5, discountAllowed:10, price:1200);

            //product1.CalculateTotalAmount();
            //product1.DisplayBill();


            //Product product2 = new Product();
            //product2.Get();
            //product2.CalculateTotalAmount();
            //product2.DisplayBill();

            // Array of objects
            //Product[] products = new Product[10];
            //for (int i = 0; i < 3; i++)
            //{
            //    products[i] = new Product();
            //    products[i].Get();
            //    products[i].CalculateTotalAmount();
            //}
            //int sum = 0;
            //foreach (Product product in products)
            //{
            //    sum += product.total;
                
            //}

            //Console.WriteLine(sum);

            // ArrayList productLIst = new ArrayList();

            //productLIst.Add(1);
            List<Product> list = new List<Product>();
            list.Add(new Product());


        }
    }

}
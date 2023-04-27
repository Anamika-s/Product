using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductProject
{
    internal class Product
    {
        string productCode;
        string productName;
        int qtyStock;
        readonly int discountAllowed;
        static string brand;
        //const float totalDiscount = .05f;
        int price;
        public int total;
        public Product() {
            Console.WriteLine("ENter Discount");
            discountAllowed = Byte.Parse(Console.ReadLine());
        }
        public Product(string productCode,
            string productName,
        int qtyStock, int discountAllowed, int price)

        {
            this.productCode = productCode;
            this.productName = productName;
            this.qtyStock = qtyStock;
            this.discountAllowed = discountAllowed;
            this.price = price;

        }
        static Product()
        {
            brand = "Levis";
        }
        public void Get()
        {
            Console.WriteLine("ENter PCode");
            productCode = Console.ReadLine();
            Console.WriteLine("Enter Product NAme");
            productName = Console.ReadLine();
            Console.WriteLine("ENter Qty");
            qtyStock = Byte.Parse(Console.ReadLine());
            Console.WriteLine("ENter Price");
            price = Byte.Parse(Console.ReadLine());

        }


        public void CalculateTotalAmount()
        {
            total = price - (discountAllowed);

        }

        public void DisplayBill()
        {
            Console.WriteLine("INVOICE DATE " + DateTime.Now);
            Console.WriteLine("*****************************");
            Console.WriteLine("Product Code " + productCode);
            Console.WriteLine("Product Name " + productName);
            Console.WriteLine("Qty " + qtyStock);


        }

    }
}
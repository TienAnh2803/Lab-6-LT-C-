using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PhoneLab6;

    public class PhoneLab6
{
    public int id;
    public int shop_id;
    public string name;
    public int price;
    public string des;
    public PhoneLab6(int id, int shop_id, string name, int price, string des ) 
    {
        this.id = id;
        this.shop_id = shop_id;
        this.name = name;
        this.price = price;
        this.des = des;

    }
    public class ShopLab6
    {
        public int id;
        public string name;
        public string area;
        public ShopLab6(int id, string name, string area)
        {
            this.id = id;
            this.name = name;
            this.area = area;
        }
    }
}

    class Program
{ 
        static void Main(string[] args)
        {
        List<ShopLab6> listShop = new List<ShopLab6>();
        List<PhoneLab6> listPhone = new List<PhoneLab6>();
        listShop.Add(new ShopLab6(1, "HCM", "Quan12"));
        listShop.Add(new ShopLab6(2, "HaNoi", "Quan7"));
        listShop.Add(new ShopLab6(3, "DaNang", "QuanLienChieu"));

        listPhone.Add(new PhoneLab6(1,1, "IP15", 100, "Doc la binh duong"));
        listPhone.Add(new PhoneLab6(2, 2, "IP16", 1000, "Doc la binh duong"));
        listPhone.Add(new PhoneLab6(3, 3, "IP17", 10000, "Doc la binh duong"));
        listPhone.Add(new PhoneLab6(4, 1, "IP18", 100000, "Doc la binh duong"));

        var query = from listShops in listShop
                    join listPhones in listPhone on listShops.id equals listPhones.id
                    select new
                    {
                        listShops.name,
                        listPhones.id,
                        listPhones.price
                    };
        foreach(var shop in query)
        {
            Console.WriteLine("Don hang:" + shop);
        }
        }

        

}


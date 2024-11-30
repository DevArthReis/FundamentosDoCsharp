using System;

namespace MeuApp
{
    class Tipos
    {
        static void Main(string[] args)
        { 

            Product mouse = new Product(1,"MouseGamer",32.50,EproductType.Product);
            var manutencaoEletrica = new Product(2,"manutenção eletrica residencial ",500,EproductType.Service);
            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.Write(mouse.Type);
            Console.Write((int)mouse.Type);
        
        
        }
    }
    struct Product{
        public Product(int id,string name,double price, EproductType type){
            Id = id;
            Name = name;
            Price =  price;
            Type = type;
        }
        public int Id;
        public string Name;
        public double Price;
        public EproductType Type;
        public double PriceInDolar(double dolar){
            return Price * dolar;
        }
    }
    enum EproductType{
        Product = 1,
        Service = 2

    }
}

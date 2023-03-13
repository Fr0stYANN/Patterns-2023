using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{

    // Single Responsibility - class operates only with product entity
    // Liskov Substitution Principle - by default in c#
    // Open-Closed can be extended by c# extension methods and inheritance
    public class Product
    {
        public Guid Id { get; set; }   

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string ProducerName { get; set; } = string.Empty; 

        public decimal Price { get; set; }  

        public int Amount { get; set; }

        public Product(Guid id, string name, string description, string producerName, decimal price, int amount)
        {
            Id = id;
            Name = name;
            Description = description;
            ProducerName = producerName;
            Price = price;
            Amount = amount;
        }

        public void SubstractPrice(decimal price)
        {
            if (Price >= price)
                Price -= price;
        }

        public override string ToString()
        {
            return $"ProductId: {Id} \n Name: {Name} \n Description: {Description} \n ProducerName: {ProducerName} \n Price: {Price} \n Amount: {Amount}";
        }
    }
}

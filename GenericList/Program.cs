using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------Int List-----------------------------------------------------");
            List<int> list = new List<int>();
            list.Add(2);
            list.Add(3);
            list.Add(4);

            list.Insert(0, 1);
            list.Insert(0, 0);

            list.AddRange(list);

            list.Sort();
            list.Reverse();

            list.RemoveRange(1,3);

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------------String List-------------------------------------------------");

            List<string> list2 = new List<string>();
            list2.Add("Hello");
            list2.Add("Good");
            list2.Add("Morning");

            list2.Insert(0, "hi");

            list2.RemoveRange(0,1);

            foreach (string item in list2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------------------Stack String-----------------------------------------------------");
            Stack<string> stack1  = new Stack<string>();
            stack1.Push("Afternonn");
            foreach(string item in stack1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------------------Queue String-------------------------------------------------------------");
            Queue<string> queue1 = new Queue<string>();
            queue1.Enqueue("Hello");
            queue1.Enqueue("hiii");

            queue1.Dequeue();
            foreach(string item in queue1)
            {
                Console.WriteLine(item);
            }
            


            Console.WriteLine("-----------------------------------ProductList-------------------------------------------------------------");

            List<Product> product = new List<Product>();
            product.Add(new Product { Id = 1, Name = "Laptop", Price= 600 });
            product.Add(new Product { Id = 2, Name = "Mobile", Price = 10000 });
            product.Add(new Product { Id = 3, Name = "Mouse", Price = 4000 });
            product.Add(new Product { Id = 4, Name = "Keyboard", Price = 3000 });

            
            foreach(Product prod in product)
            {
                Console.WriteLine($"{prod.Id} {prod.Name} {prod.Price}");
            }

            Console.WriteLine("----------------------------Stack Product-------------------------------------------------------");
            Stack<Product> stack = new Stack<Product>();
            stack.Push(new Product { Id = 11, Name = "Tv", Price = 100000 });
            stack.Push(new Product { Id = 12, Name = "Charger", Price = 500 });

            stack.Pop();
           // stack.Peek();
            foreach(Product prod in stack)
            {
                Console.WriteLine($"{prod.Id} {prod.Name} {prod.Price}");
            }

            Console.WriteLine("---------------------------------------Queue Product----------------------------------------------------------------");
            Queue<Product> queue = new Queue<Product>();
            queue.Enqueue(new Product { Id = 101, Name = "Xyz", Price = 20 });
            queue.Enqueue(new Product { Id = 102, Name = "abcs", Price = 350 });

            queue.Dequeue();
            foreach(Product prod in queue)
            {
                Console.WriteLine($"{prod.Id} {prod.Name} {prod.Price}");
            }
            
            
            
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Singletons;

namespace PizzaBox.Client
{
    class Program
    {
        /// <param name="args"></param>

        List<APizza> pizzas = PizzaSingleton.Instance.Pizzas;

        List<Crust> crusts = CrustSingleton.Instance.Crusts;

        List<Size> sizes = SizeSingleton.Instance.mySize;
        List<Topping> toppings = ToppingSingleton.Instance.topping;

        //creating a new list for APizza
        List<APizza> myOrder = new List<APizza>();
        static void Main(string[] args)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("   PizzaBox  "); //title
            Console.WriteLine();

            
            Console.WriteLine("IF YOUR ARE OUR CUSTOMER PLEASE ENTER 1");
            Console.WriteLine("TO EXIT THE APPLICATION ENTER 0");

            var userIn = Console.ReadLine(); // excepts the user input 1 or 0

            if (userIn == "1")
            {
                AsACustomer(); //calling as a Customer method
            }

            if(userIn != "0"){
                Console.WriteLine("Please Enter A Valid Option");
            }


        }

        /// <summary>
        /// Started the application and expcepted the user input 1 to enter 
        /// </summary>

        public static void AsACustomer() // as a customer method called when user input 1 is selected
        {
            Program p = new Program();


            int input;
            do{
                System.Console.WriteLine();
                System.Console.WriteLine("Select your Store "); //prompt to select a store

                int n = 0;

                //StoreSingleton.Instance.Stores


                foreach (var store in StoreSingleton.Instance.Stores) // stores called from singleton 
                {
                    Console.WriteLine(++n + ": " + store);
                }

                // select a store
                input = Convert.ToInt32(Console.ReadLine());
                if(input != 1 && input != 2){
                    Console.WriteLine("Please Enter A Valid Option"); //must choose from 2 options
                }
            }while(input != 1 && input != 2);
            
            int input2 = 3;
            do
            {
                // print the customer menu
                System.Console.WriteLine();
                System.Console.WriteLine("1. Place Order");
                System.Console.WriteLine("2. View Your Cart");
                System.Console.WriteLine("3. Checkout");
                System.Console.WriteLine("4. View Your History");
                System.Console.WriteLine("5. Exit");

                // select a menu option
                input2 = int.Parse(Console.ReadLine()); //reading the user input from menu

                switch (input2)
                {
                    case 1:
                        p.placeOrder();// placeOrder() method invoked if input 1
                        break;
                    case 2:
                        p.orderlist();//OrderList() if input 2
                        break;
                    case 3:
                        p.checkOut(StoreSingleton.Instance.Stores[input-1].Name); //to checkout 
                        break;
                    case 4:
                        p.orderHistory();
                        break;
                    case 5: 
                        Console.WriteLine("Good Bye! ");
                        break;
                    default:
                        Console.WriteLine("Please Enter A Valid Option");
                        break;
                }

            } while (input2 != 5);
        }

        public void placeOrder()
        {
            Console.WriteLine();
            int i = 0;
            foreach (var pizza in pizzas)//pizzas from pizzasingelton
            {
                Console.WriteLine(++i + ": " + pizza);
            }

            // select a type of pizza
            var input3 = Console.ReadLine();
            switch (input3)
            {
                case "1":
                    customPizza();
                    break;
                case "2":
                    preSetPizza(pizzas[Convert.ToInt32(input3) - 1]);
                    break;
                case "3":
                    preSetPizza(pizzas[Convert.ToInt32(input3) - 1]);
                    break;
                case "4":
                    preSetPizza(pizzas[Convert.ToInt32(input3) - 1]);
                    break;
                default:
                    Console.WriteLine("Please Select A Valid Option");
                    break;
            }

        }
        void customPizza()
        {
            var cPizza = new CustomPizza();

            Options(cPizza);

            //string[] toppings = new string[] {"Onion", "Green Peppers", "Mushrooms" };
            var toppings = new Dictionary<string, int>{ {"Onion", 1}, {"Spinach", 1}, {"Mushrooms", 1}, {"Extra Cheese", 1},
                                                       {"olives", 1}, {"Pepperoni", 1}};
            int t;
            
            
            for(int i = 0; i < 4; i++){ //less then 4 toppings
                Console.WriteLine();
                Console.WriteLine("Choose your Toppings: ");
                Console.WriteLine();
                Console.WriteLine("1: Onion ----------$ 1.00 ");
                Console.WriteLine("2: Spinach ------- $ 1.00 ");
                Console.WriteLine("3: Mushrooms ------$ 1.00 ");
                Console.WriteLine("4: Extra Cheese ---$ 1.00 ");
                Console.WriteLine("5: Olives -------- $ 1.00 ");
                Console.WriteLine("6: Pepperoni ------$ 1.00 ");
                Console.WriteLine();
                Console.WriteLine("0: Done Adding Toppings");

                t = Convert.ToInt32(Console.ReadLine()); //ecept user input
                if(t == 0){
                    break;
                }
                else if (t > 0 && t < 7)
                {   
                    cPizza.Toppings[i].Name = toppings.ElementAt(t - 1).Key; 
                    //cPizza.Toppings[i].Price = toppings.ElementAt(t - 1).Value;
                }
                else{
                    Console.WriteLine("Please select a valid option");
                    --i;
                }
            }

            myOrder.Add(cPizza); // add pizza to my Ordere
        }

        // Pre set pizzas if customer wanna order already made pizzas 
        void preSetPizza(APizza pizza)
        {
            Options(pizza);
            myOrder.Add(pizza);
        }

        void Options(APizza cPizza)
        {
            
            System.Console.WriteLine();
            Console.WriteLine("Choose a Crust: ");
            Console.WriteLine("1: Thick ------- $ 1.00 ");
            Console.WriteLine("2: Thin  ------- $ 1.00 ");
            int c = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {

                case 1:
                    cPizza.Crust.Name = crusts[0].Name;
                    cPizza.Crust.Price = crusts[0].Price;
                    break;
                case 2:
                    cPizza.Crust.Name = crusts[1].Name;
                    cPizza.Crust.Price = crusts[1].Price;
                    break;

                default:
                    Console.WriteLine("Please Enter A valid Option");
                    break;
            }

            System.Console.WriteLine();
            Console.WriteLine("Choose a Size: ");
            Console.WriteLine("1: Small -------- $ 9.00 ");
            Console.WriteLine("2: Medium ------- $ 12.00 ");
            Console.WriteLine("3: Large -------- $ 15.00 ");

            int s = Convert.ToInt32(Console.ReadLine());
            switch (s)
            {
                case 1:
                    cPizza.Size.Name = sizes[0].Name;
                    cPizza.Size.Price = sizes[0].Price;
                    break;
                case 2:
                    cPizza.Size.Name = sizes[1].Name;
                    cPizza.Size.Price = sizes[1].Price;
                    break;

                case 3:
                    cPizza.Size.Name = sizes[2].Name;
                    cPizza.Size.Price = sizes[2].Price;
                    break;

                default:
                    Console.WriteLine("Please Enter A valid Option");
                    break;
            }
        }

         void checkOut(string StoreName)
        {
            Customer customer = new Customer();
            Order order = new Order(myOrder);
            var total = order.calcTotal();

            Console.WriteLine();
            Console.WriteLine("List of Pizza that you ordered: ");
            foreach (var p in myOrder)
            {
                Console.WriteLine(p.Name); 
            }

            Console.WriteLine("Your Total:  $" + total);

            Console.WriteLine();
            Console.WriteLine("Please Enter your Name: ");
            customer.Name = Console.ReadLine(); //excepts user name

            Console.WriteLine("Please Enter your Email: ");
            customer.Email = Console.ReadLine(); //excepts user email

            order.StoreName = StoreName;
            order.customerEmail = customer.Email;

            var os = OrderSingleton.Instance;

            os.Seeding(order); // saving order

        }

        void orderlist(){
            Order order = new Order(myOrder);
            var total = order.calcTotal();
            Console.WriteLine();
            Console.WriteLine("List of Pizza that you ordered: ");
            foreach (var p in myOrder)
            {
                Console.WriteLine(p.Name);
            }

            Console.WriteLine("Your Total:  $" + total);
        }
        void orderHistory(){
            Console.WriteLine("Plese Enter your Email ");
            var email = Console.ReadLine();

            var sinOrd = OrderSingleton.Instance; //calling order instance from order singleton

            var order = sinOrd.readOrderList(); //reading orderlist

            if(email.Equals(order.customerEmail)){
                Console.WriteLine("Store: " + order.StoreName);
                foreach(var p in order.Pizzas){
                    Console.WriteLine(p.Size.Name+ " " + p.Name + " " + p.Crust.Name + " Crust with");
                    foreach(var t in p.Toppings){
                        Console.Write(t.Name + " ");
                    }
              }
                var mytotal = order.calcTotal();
                Console.WriteLine("Total: $ " + mytotal);
            }
            
        }

    }
}

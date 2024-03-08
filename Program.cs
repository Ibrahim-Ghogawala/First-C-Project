
using System.Collections;

string readOrder = null;

double total = 0;
int carryOn = 0;

int noItem;

ArrayList recipt = new ArrayList();
ArrayList numofItem = new ArrayList();

string[] items = new string[5]; 

items[0] = "Coffee";
items[1] = "Chocolate Cake";
items[2] = "Fries";
items[3] = "Sandwich";
items[4] = "Milkshake";

double[] price = new double[5];

price[0] = 30.00;
price[1] = 35.00;
price[2] = 20.00;
price[3] = 25.00;
price[4] = 15.00;

Console.WriteLine("Welcome to our Cafe!");

    while (carryOn != 2) {

    //Console.WriteLine("What would you like to order? \n 1." + item1 + ": R" + coffee + "\n 2." + item2 + ": R" + chocolatecake +
    // "\n 3." + item3 + ": R" + fries + " \n 4." + item4 + ": R" + sandwich + " \n 5." + item5 + ": R" + milkshake);

    Console.WriteLine("What would you like to order? \n 1. Coffee : R30 \n 2. Chocolate Cake : R35 \n 3. Fries : R20 \n 4. Cheese Sandwich : R25 " +
        "\n 5. Milkshake : R15");
    readOrder = Console.ReadLine();

    Console.WriteLine("How many would you like of these?");
    noItem = Convert.ToInt32(Console.ReadLine());

    switch (readOrder)
    {
        case "1":
            total = total + (noItem * price[0]);
            recipt.Add("Coffee : R30");
            numofItem.Add(noItem);
        break;
        case "2":
            total = total + (noItem * price[1]);
            recipt.Add("Chocolate Cake : R35");
            numofItem.Add(noItem);
        break;
        case "3":
            total = total + (noItem * price[2]);
            recipt.Add("Fries : R20");
            numofItem.Add(noItem);
        break;
        case "4":
            total = total + (noItem * price[3]);
            recipt.Add("Cheese Sandwich : R25");
            numofItem.Add(noItem);
        break;
        case "5":
            total = total + (noItem * price[4]);
            recipt.Add("Milkshake : R15");
            numofItem.Add(noItem);
        break;
        default:
            Console.WriteLine("Sorry that option is not availble yet, Coming Soon!");
        break;
    }

    Console.WriteLine("Would you like to order something else? \n 1.Yes \n 2.No");
    carryOn = Convert.ToInt32(Console.ReadLine());

    }

    Console.WriteLine("Your order is as follows: \n");

            for (int i = 0; i < numofItem.Count; i++)
            {
                Console.WriteLine(numofItem[i] + "x " + recipt[i]);
            }

    Console.WriteLine("\nYour total is: R" + total);
    



﻿Character myChar = new();
Console.WriteLine("Your inventory cointains:");
myChar.Backpack.Display();

Armour helmet = new Armour() { Name = "Crown of elli ", Weight = 3f };

Console.WriteLine();
Console.WriteLine("You've found a " + helmet.Name + " Pick it up? [yes|no]");
Console.WriteLine();

string choice = "";
while (choice != "yes" && choice != "no")
{
  choice = Console.ReadLine().ToLower();
}

if (choice == "yes")
{
  Console.WriteLine("Adding it to your inventory");
  myChar.Backpack.Items.Add(helmet);
}
else {
  Console.WriteLine("Throing in it the river");
}

Console.WriteLine("Your inventory now cointains:");
myChar.Backpack.Display();

Console.ReadLine();

public class Character
{
  public int Hp;
  public string Name;
  public Inventory Backpack;

  public Character()
  {
    Backpack = new();
    Weapon w = new () { Name = "Ellis axe", Weight = 200f };
    Consumabels p = new() { Name = "potion of not dying", Weight = 10f };

    Backpack.Items.Add(w);
    Backpack.Items.Add(p);

    Hp = 100;
    Name = "";
  }
}
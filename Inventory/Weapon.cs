public class Weapon : Item
{
    public int MinDamage = 5;
    public int MaxDamage = 25;

    public int Attack()
    {
        return Random.Shared.Next(MinDamage,MaxDamage);
    }
}
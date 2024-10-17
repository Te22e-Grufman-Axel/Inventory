public class Consumabels : Item
{
    public int Maxuses = 5;
    public int CurentUses = 0;

    public void Use(Character target)
    {
        if (CurentUses > 0)
        {
            target.Hp += 10;
            CurentUses++;
        }
    }
}
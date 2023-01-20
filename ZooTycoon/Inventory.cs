namespace ZooTycoon;

public class Inventory
{
    private List<Countainer> inventory = new List<Countainer>(45);

    public void AddItemToInventory(int sumItems, IItem  item)
    {
        for (int i = 0; i < inventory.Count; i++)
        {
            inventory[i].AddItemToContainer(item, sumItems);
        }
    }



}
namespace ZooTycoon;

public class Countainer
{
    public int Count;
    public string ItemName;

    public Countainer(int count, string itemName)
    {
        Count = count;
        itemName = ItemName;
    }

    public void AddItemToContainer(IItem item, int sumItems)
    {
        if (item.Name == ItemName)
        {
            if (Count < 99)
            {
                Count = Count + sumItems; 
            }
            else
            {
                Count = 99 ;
                throw new ArgumentException("Ячейка заполнена");
            }
            
        }
        else
        {
            throw new ArgumentException("Невозможно добавить айтом в данную ячейку");
        }
    }

    public void TakeItemOutCounteiner(IItem item, int SumItems)
    {
        if (item.Name == ItemName && Count != 0)
        {
            Count = Count - SumItems;
        }
    }
}
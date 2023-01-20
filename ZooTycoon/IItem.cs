namespace ZooTycoon;

public interface IItem
{
    string Name { set; get; }
    decimal SellCoast { set; get; }

    void SellItem();
    void TakeItem();
    void DeleteItem();
}
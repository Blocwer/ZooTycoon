namespace ZooTycoon;

public class GameSession
{
    public string PlayerName { set; get; }
    private DateTime StartSessionTime = DateTime.Now;
    
    private decimal money = 1000M;
    public decimal Money
    {
        private set
        {
            if (value >= 0M)
            {
                money = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("денег не может быть меньше нуля!");
            }
        }
        get { return money; }
    }
    
    public List<Animal> MyAnimals;
    
    




}
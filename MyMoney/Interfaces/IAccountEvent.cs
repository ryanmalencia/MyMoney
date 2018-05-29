namespace MyMoney.Interfaces
{
    public interface IAccountEvent
    {
        string GetTitle();
        double GetAmount();
        string GetEventType();
    }
}

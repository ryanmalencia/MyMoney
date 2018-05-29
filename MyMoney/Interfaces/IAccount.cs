namespace MyMoney.Interfaces
{
    public interface IAccount
    {
        string GetName();
        string GetProvider();
        string GetAccountType();
        bool AddEvent(IAccountEvent Event);
    }
}

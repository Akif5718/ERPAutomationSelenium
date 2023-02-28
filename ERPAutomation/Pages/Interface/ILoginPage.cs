namespace ERPAutomation.Pages.Interface
{
    public interface ILoginPage
    {
        void EnterUserNameAndPassword(string userName, string password);
        void ClickLogin();
    }
}
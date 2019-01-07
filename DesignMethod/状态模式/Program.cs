using System;

namespace DesignMethod.StatePattern
{
    public class Program : OpenDesign
    {
        public override void Open()
        {
            Account account = new Account("Lear");
            account.Deposit(1000.00);
            account.Deposit(600.00);
            account.Deposit(200.00);

            //利息
            account.PayInterest();

            //取钱
            account.Withdraw(2000.00);
            account.Withdraw(500.00);
            
        }
    }
}
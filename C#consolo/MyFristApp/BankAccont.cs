
public class BankAccont
{
     private double balance; //Private can't be accised directly 

     public void Deposit(double amount)
     {
        balance += amount;
     }

     public double GetBalance()
     {
        return balance;
     }
}
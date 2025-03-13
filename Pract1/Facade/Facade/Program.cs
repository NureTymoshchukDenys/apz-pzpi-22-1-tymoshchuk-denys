using System;

class Bank
{
    public bool Verify(int amount)
    {
        return amount < 999;
    }
}

class CreditHistory
{
    public bool Check(string name)
    {
        return true; 
    }
}

class Balance
{
    public bool Check(string name)
    {
        return true; 
    }
}

class Credit
{
    private string name;

    public Credit(string name)
    {
        this.name = name;
    }

    public string ApplyFor(int amount)
    {
        var isApproved = new Bank().Verify(amount);
        var bankResult = isApproved ? "approved" : "denied";

        var isPositiveBalance = new Balance().Check(this.name);
        var balance = isPositiveBalance ? "positive balance" : "negative balance";

        var isGoodCreditHistory = new CreditHistory().Check(this.name);
        var creditHistory = isGoodCreditHistory ? "good" : "poor";

        return $"{this.name} has been {bankResult} for the {amount} credit. With a {creditHistory} credit standing and having a {balance}.";
    }
}

class Program
{
    static void Main(string[] args)
    {
        var credit = new Credit("John");
        var creditSmall = credit.ApplyFor(99);
        var creditMedium = credit.ApplyFor(199);
        var creditLarge = credit.ApplyFor(99999);

        Console.WriteLine($"creditSmall: {creditSmall}");
        Console.WriteLine($"creditMedium: {creditMedium}");
        Console.WriteLine($"creditLarge: {creditLarge}");
    }
}
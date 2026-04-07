class bankAccount
{
    public string accountName;
    public string password;
    public float accountNumber;
    public double balance;
    public double creditCardLimit;
    public bool haveCreditCard;

public void userDetails()
    {
        Console.WriteLine($"Your Account Name: {accountName}");
        Console.WriteLine($"Your Password: {password}");
        Console.WriteLine($"Your Account Number: {accountNumber}");
        Console.WriteLine($"Your Balance: {balance}");

        if (haveCreditCard)
        {
            Console.WriteLine($"Your Credit Card limit: {creditCardLimit}");
        }
        else
        {
            Console.WriteLine("You want a new credit card?");
        }
    }
}
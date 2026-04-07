class bankAccount
{
    //public string AccountName;
    //public string Password;
    //public float AccountNumber;
    //public double Balance;
    //public double CreditCardLimit;
    //public bool haveCreditCard;

    public string AccountName { get; set; }
    public string Password { get; set; }
    public float AccountNumber { get; set; }
    public double Balance { get; set; }
    public double CreditCardLimit =>
        Balance * 1.3;
    public bool HaveCreditCard { get; set; }




    public void userDetails()
    {
        Console.WriteLine($"Your Account Name: {AccountName}");
        Console.WriteLine($"Your Password: {Password}");
        Console.WriteLine($"Your Account Number: {AccountNumber}");
        Console.WriteLine($"Your Balance: {Balance:C2}");

        if (HaveCreditCard)
        {
            Console.WriteLine($"Your Credit Card limit: {CreditCardLimit:C2}");
        }
        else
        {
            Console.WriteLine("You want a new credit card?");
        }
    }
}
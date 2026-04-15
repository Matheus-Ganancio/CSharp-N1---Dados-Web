class Car
{
    //public float Accelerate;
    //public bool Brake;
    //public bool Honk;

    public float Accelerate { get; set; }
    public bool Brake { get; set; }
    public bool Honk { get; set; }

    public string CarDetails =>
        $"The 2023 Toyota Corolla is a reliable and " +
        $"fuel-efficient sedan crafted by one of the " +
        $"world's most trusted automakers";

    public void carInfo()
    {
        Console.WriteLine($"Car Speed: {Accelerate} Km/h");
        if (Honk)
        {
            Console.WriteLine("You need to Brake!!!");
            //Console.WriteLine("\n");
            if (Brake)
            {
                Console.WriteLine("You doing well");
            }
            else
            {
                Console.WriteLine("BRAKE NOW!!!");
            }
        }
        else
        {
            Console.WriteLine("Dont need to worry");
        }
    }
}
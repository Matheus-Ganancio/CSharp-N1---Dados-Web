class Car
{
    public float accelerate;
    public bool honk;
    public bool brake;

    public void carInfo()
    {
        Console.WriteLine($"Car Speed: {accelerate} Km/h");
        if (honk)
        {
            Console.Write("You need to brake!!!");
            Console.WriteLine("\n");
            if (brake)
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
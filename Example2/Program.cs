Cook bob = new Cook("Bob");
bob.MakeDinner();


class Cook
{
    public string Name { get; set; }
    public Cook(string name)
    {
        this.Name = name;
    }

    public void MakeDinner()
    {
            Console.WriteLine("Peeling potatoes");
            Console.WriteLine("Place the peeled potatoes on the fire");
            Console.WriteLine("Drain off the remaining water and mash the boiled potatoes");
            Console.WriteLine("Sprinkle the puree with spices and herbs");
            Console.WriteLine("Mashed potatoes are ready");
    }
}
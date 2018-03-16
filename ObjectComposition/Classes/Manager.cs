namespace ObjectComposition.Classes
{
    internal class Manager : Employee
    {
        private readonly CoffeeMachine _coffeeMaker;
        public Manager(CoffeeMachine coffeeMaker)
        {
            _coffeeMaker = coffeeMaker;
        }

        public int Rank { get; set; }

        public void StartDay()
        {
            _coffeeMaker?.MakeCoffee();
        }
    }
}
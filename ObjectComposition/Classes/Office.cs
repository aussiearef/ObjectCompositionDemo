using System.Collections.Generic;

namespace ObjectComposition.Classes
{
    internal class Office
    {
        private readonly CoffeeMachine _coffeeMaker;

        internal Office()
        {
            _coffeeMaker = new CoffeeMachine();
        }

        public List<Employee> Employees { get; set; } = new List<Employee>();


        private void StartWorkDay()
        {
            var manager = new Manager(_coffeeMaker);
            manager.StartDay();
        }
    }
}
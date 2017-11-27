using System;

namespace Amazon
{
    public class Customer
    {
        public class RateCalculator
        {
            public int Calculate(Customer customer)
            {
                return 0;
            }
        }
        
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);

            Console.WriteLine("Promote logic changed.");

        }

        protected int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }
}
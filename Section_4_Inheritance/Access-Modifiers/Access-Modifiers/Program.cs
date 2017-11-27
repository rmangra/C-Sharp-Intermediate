using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon;

namespace Access_Modifiers
{
    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            var rating = this.CalculateRating(excludeOrders: true);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
        }
    }
}

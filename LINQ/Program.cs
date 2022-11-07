using System.Collections.Generic;
using System.Linq;
namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> golfBrands = new List<string>() {"Callaway", "Nike", "TaylorMade", "Ping", "Vice", "Bridgestone", "Puma", "Slazenger" };
            IEnumerable<string> longGolfBrand = golfBrands.OrderBy(x => x.Length);
            foreach (var i in longGolfBrand)
            {
                Console.WriteLine(i);   
            }
            
            

        }
    }
}

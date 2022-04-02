using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming.LogicalPrograms
{
    class CouponNumber
    {
        public static void DistinctCoupon() {
            Console.WriteLine("Please enter how many distinct number of coupons needed : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            List<int> list = new List<int>();
            int i = 0, count = 0;
            while (i <= num) {
                int res = random.Next(1,101);
                count++;
                if (!list.Contains(res))
                {
                    list.Add(res);
                    i++;
                    Console.WriteLine(res);
                }
                else
                {
                    continue;
                }
            }
        }
    }
}

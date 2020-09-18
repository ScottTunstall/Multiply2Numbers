using System;

namespace Multiply2Numbers
{
    public class Multiplier
    {
        //
        // 00001111 x
        // 00000011 = 
        // 00101101


        public long Multiply(int multiplicand, int multiplier)
        {
            long product = 0;

            for (int i = 0; i < 32; i++)
            {
                var digit1 = (multiplier & (1 << i)) != 0 ? 1: 0 ;

                var result = MultiplyBy(multiplicand, digit1, i);

                product |= result;

                Console.WriteLine($"For iteration {i} product is {product}");
            }
            
            return product;
        }

        private long MultiplyBy(int multiplicand, int bit, int shift)
        {
            if (bit == 1)
                return multiplicand << shift;

            return 0;
        }
    }
}

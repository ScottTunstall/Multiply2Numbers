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
            long a = multiplicand;
            var b = multiplier;
            
            while (b>0)
            {
                // If bit 0 of multiplier is set, we use it in multiplication
                if ((b&1)!=0)
                    product += a;  // NOTE: using the | operator here gives incorrect result

                a <<=1;

                // Ensure bit 0 is set to next digit to multiply by
                b >>= 1;
            }
            
            return product;
        }

    }
}

using System.Collections;

namespace ConsoleApp5;

public class Goldbach
{ 
    
    public BitArray isPrimeNumber(BitArray bitArray)//埃拉托斯特尼筛法
    {
        for (int i = 0; i < bitArray.Length; i++)//对数组赋初值为true,表示为素数
        {
            bitArray[i] = true;
        }

        bitArray[0] = false;
        bitArray[1] = false;

        for (int p = 2; p < bitArray.Length-1; p++)//将非素数置false
        {
            if (bitArray[p])
            {
                for (int i = p * p; i <= bitArray.Length-1; i += p)//如果有因数，则非素数
                {
                    bitArray[i] = false;//置false
                }
            }
        }
        return bitArray;
    }

    public void getPrimeNumber(BitArray bitArray,int first,int last)
    {
        for (int i = first; i <= last; i+=2)
        {
            for (int j = 2; j <= i/2; j++)
            {
                if (bitArray[j] && bitArray[i-j])
                {
                    Console.WriteLine(""+i+"="+""+j+"+"+ (i - j));
                }
            }
        }
    }
    
}
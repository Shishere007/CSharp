using System;


// sum of factorial of digts


interface ISOFOD{
    long read_number();
    long factorial(long number);

    void final_function(long number);
}
class SOFOD :ISOFOD {

    public long read_number(){
        Console.Write("Number : ") ;
        return long.Parse(Console.ReadLine());
    }

    public long factorial(long number){
        long fact = 1 ;
        for (long loopVar = 1 ;loopVar <= number; ++loopVar){
            fact *= loopVar;
        }
        return fact;
    }

    public void final_function(long number){
        long sum = 0;
        while (number != 0) {
            sum += factorial(number % 10);
            number /= 10;
        }
        Console.Write("Sum is {0}",sum);
    }
    public static void Main(String[] args){
        SOFOD obj = new SOFOD();
        obj.final_function(obj.read_number());
        Console.ReadKey();
    }
}

namespace mathematical
{
    
    
}
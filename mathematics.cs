using Internal;
using System.Collections;
using System;

interface Imathematics{
    int show_options();
    int read_number();
    Boolean check_prime(int number);
    int find_factorial(int number);
}

class basic : Imathematics {
    public int read_number(){
        Console.Write("Number : ") ;
        return int.Parse(Console.ReadLine());
    }
    public int find_factorial(int number){
        int fact = 1 ;
        for (int loopVar = 1 ;loopVar <= number; ++loopVar){
            fact *= loopVar;
        }
        return fact;
    }
    public Boolean check_prime(int number){
        for (int loopVar = 2 ; loopVar < number / 2 ; ++loopVar){
            if (number % loopVar == 0) 
            return false;
        }
        return true;
    }

    public int show_options() {
        Console.WriteLine("Menu");
        Console.WriteLine("1- Factorial");
        Console.WriteLine("2- Check Prime");
        Console.WriteLine("3- Exit");
        Console.Write("Option : ");
        return int.Parse(Console.Read());
    }
}

class mathematics : basic {
    
}
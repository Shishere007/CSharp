using System.Collections;
using System;

// interface creation or blueprint the class
interface Iprime{
    int read_number();
    Boolean check_prime(int number);
    void show_result(Boolean status);
}
public class prime : Iprime{

    public Boolean check_prime(int number){
        for (int loopVar = 2 ; loopVar*loopVar <= number ; ++loopVar){
            if (number % loopVar == 0) 
            return false;
        }
        return true;
    }

    public int read_number(){
        Console.Write("Number : ") ;
        return int.Parse(Console.ReadLine());
    }

    public void show_result(Boolean status){
        if (status == true){
            Console.WriteLine("Prime Number");
        }else{
            Console.WriteLine("Not a Prime Number");
        }
    }
}

public class main_class : prime {
    public static void Main(String[] args){
        main_class obj = new main_class();
        obj.show_result(obj.check_prime(obj.read_number()));
        // waiting for user enter any key
        Console.ReadKey();
    }
}


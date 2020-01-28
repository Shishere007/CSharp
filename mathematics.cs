using Internal;
using System.Collections;
using System;

interface Ibasic {
    int read_number();
    Boolean is_prime(int number);
    int factorial(int number);
}

interface Imathematics {
    int show_options();
    void menu_driven();
    void is_number_prime();
    void find_factorial();
}

class basic : Ibasic {
    // Read a number from user
    public int read_number(){
        Console.Write("Number : ") ;
        return int.Parse(Console.ReadLine());
    }
    // to find factorial
    public int factorial(int number){
        int fact = 1 ;
        for (int loopVar = 1 ;loopVar <= number; ++loopVar){
            fact *= loopVar;
        }
        return fact;
    }
    // To check if a number is prime
    public Boolean is_prime(int number){
        for (int loopVar = 2 ; loopVar*loopVar <= number ; ++loopVar){
            if (number % loopVar == 0) 
            return false;
        }
        return true;
    }   
}

class mathematics : basic,Imathematics {
    public void is_number_prime() {
        mathematics obj = new mathematics();
        try{
            int number = obj.read_number();
            if (obj.is_prime(number)){
                Console.WriteLine("{0} is a Prime number",number);
            }else{
                Console.WriteLine("{0} is not a Prime number",number);
            }
        }catch(Exception e){
            Console.WriteLine("mathematics.is_number_prime :- {0}",e);
        }finally{
            Console.ReadKey();
        }
        
    }

    public void find_factorial() {
        mathematics obj = new mathematics();
        try{
            int number = obj.read_number();
            Console.WriteLine("Factorial of {0} = {1}",number,obj.factorial(number));
        }catch(Exception e){
            Console.WriteLine("mathematics.find_factorial :- {0}",e);
        }finally{
            Console.ReadKey();
        }
        
    }

    public int show_options() {
        mathematics obj = new mathematics();
        try{
            Console.WriteLine("Menu");
            Console.WriteLine("1- Factorial");
            Console.WriteLine("2- Check Prime");
            Console.WriteLine("3- Exit");
            Console.Write("Option : ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }catch(Exception e){
            Console.WriteLine("mathematics.show_options :- {0}",e);
            return 0;
        }
        
    }

    public void menu_driven(){
        mathematics obj = new mathematics();
        int option;
        while(true){
            try{
                option = obj.show_options();
            }catch(Exception){
                Console.WriteLine("Incorrect input");
                continue;
            }
            switch(option){
                case 0 : Console.WriteLine("Error found in program");
                         System.Environment.Exit(0);
                break;
                case 1 : obj.find_factorial();
                break;
                case 2 : obj.is_number_prime();
                break;
                case 3 : System.Environment.Exit(0);
                break;
                default : Console.WriteLine("Wrong Choice..!!");
                break;
            }
        }
    }
}


class main_class : mathematics {
    public static void Main(String[] args){
        main_class obj = new main_class();
        try{
            obj.menu_driven();
        }catch(Exception e){
            Console.WriteLine("main_class.Main :- {0}",e);
        }
    }
}


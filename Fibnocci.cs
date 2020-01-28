using System;
public class Fibnocci {

    public static void Main (String[] args) {
        int a,b,c,count;
        Console.WriteLine ("Count : ");
        count = int.Parse(Console.ReadLine());
        a = -1;
        b = 1;
        for (int loopVar = 0; loopVar < count ; ++loopVar){
            c = a + b ;
            Console.Write("{0}\t",c);
            a = b ;
            b = c ;
        }
        Console.ReadKey();
    }
}

using System;

public class DEMO {
    public static void Main(){
        int a = 1;
        int b = 2;
        Console.WriteLine("Initial Values; A:" + a + ", B:" + b);

        a = a ^ b;
        b = a ^ b;
        a = a ^ b;

        Console.WriteLine("Swapped Values; A:" + a + ", B:" + b);
    }
}

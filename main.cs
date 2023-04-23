using System;

class Program {
  public static void Main (string[] args) {
     int num, a = 0, b = 1, c = 0;

        Console.Write("Digite um número: ");
        num = int.Parse(Console.ReadLine());

        while (c < num) {
            c = a + b;
            a = b;
            b = c;
        }

        if (c == num) {
            Console.WriteLine($"{num} pertence à sequência de Fibonacci.");
        } else {
            Console.WriteLine($"{num} não pertence à sequência de Fibonacci.");
        }
  }
}
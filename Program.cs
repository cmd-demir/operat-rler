// See https://aka.ms/new-console-template for more information

    class Result
{

    /*
     * Complete the 'solve' function below.
     *
     * The function accepts following parameters:
     *  1. DOUBLE meal_cost
     *  2. INTEGER tip_percent
     *  3. INTEGER tax_percent
     */

    public static void solve(double meal_cost, int tip_percent, int tax_percent)
    {
    }

    

}

class Solution
{
    public static void Main(string[] args)
    {
       
       Console.WriteLine("**** Atama ve İşlemli Atama ****");
       // Atama ve İşlemli Atama

       int x = 3;
       int y = 3;
       y = y + 2;

       Console.WriteLine(y);
       y += 2;
       Console.WriteLine(y);
       y /=1;
       Console.WriteLine(y);
       x *=2;
       Console.WriteLine(x);

      Console.WriteLine("**** Mantıksal Operatörler ****");
       // Mantıksal Operatörler
       // ||, &&, !

       bool isSuccess = true;
       bool isCompleted = false;

       if(isSuccess && isCompleted);
       Console.WriteLine("Perfect!"); 

       if(isSuccess || isCompleted);
       Console.WriteLine("Great!");

       if(isSuccess && !isCompleted);
       Console.WriteLine("Fine!");


       Console.WriteLine("**** İlişkisel Operatörler ****");
       // İlişkisel Operatörler 
       // >, <, <==, >==, ==, !=

       int a = 3;
       int b = 4;
       bool sonuç = a<b;
       Console.WriteLine(sonuç);
       sonuç = a>b;
       Console.WriteLine(sonuç);
       sonuç = a>=b;
       Console.WriteLine(sonuç);
       sonuç = a<=b;
       Console.WriteLine(sonuç);
       sonuç = a==b;
       Console.WriteLine(sonuç);
       sonuç = a!=b;
       Console.WriteLine(sonuç);

       Console.WriteLine("**** Aritmetik Operatörler ****");
       // *, /, +, -,

       int sayı1 = 10;
       int sayı2 = 5;
       int sonuç1 = sayı1/sayı2;
       Console.WriteLine(sonuç1);
       sonuç1 = sayı1*sayı2;
       Console.WriteLine(sonuç1);
       sonuç1 = sayı1+sayı2;
       Console.WriteLine(sonuç1);
       sonuç1 = sayı1 ++;
       Console.WriteLine(sayı1);

       // %, :, mod alır

       int sonuç2 = 20%3;
       Console.WriteLine(sonuç2);



       










    }
}

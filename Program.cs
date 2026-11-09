//task 1
// int n = Convert.ToInt32(Console.ReadLine());

// PrintFromNumberToOne(n);

// void PrintFromNumberToOne(int number)
// {
//     for(int i=number; i>0; i--)
//     {
//         Console.Write($"{i} ");
//     }
// }

//task 2

// int summ = Sum(1,2,3,4);
// Console.WriteLine(summ);

// int Sum(int a, int b, int c, int d)
// {
    
//     return a+b+c+d;
// }

//task 3

// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rev(n));
// int rev(int f)
// {
//     int resultat = 0;
//     for(int i=f ; i>0; i /= 10)
//     {
//        resultat = resultat*10;
//        resultat += i%10; 
//     }
//     return resultat;
// }

//task 4
// int n = Convert.ToInt32(Console.ReadLine());
// PrintStars(n);
// void PrintStars(int n)
// {
//     for (int i = 0; i < n; i++)
//     {
//         Console.Write("*");
//     }
//     Console.WriteLine();
// }

//task 5

// int n = Convert.ToInt32(Console.ReadLine());
// PrintStars(n);
// void PrintStars(int n)
// {
//     for(int i = 0;i < n; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             Console.Write("*");
//         }
//         Console.WriteLine();
//     }
// }

//task 6

// int w = Convert.ToInt32(Console.ReadLine());
// int h = Convert.ToInt32(Console.ReadLine());

// p (w, h);
// void p(int w, int h)
// {
//     for (int i=0; i<h; i++)
//     {
//         for (int j=0; j<w; j++)
//         {
//             Console.Write("*");
//         }
//         Console.WriteLine();
//     }
// }

//task 7

// int n =Convert.ToInt32(Console.ReadLine());

// p (n);
// void p(int s)
// {
//     for(int i=1; i<=s; i++)
//     {
//         for(int j = 0; j < i; j++)
//         {
//             Console.Write("*");
//         }
//         Console.WriteLine();
//     }
// }

//task 8

// int n = Convert.ToInt32(Console.ReadLine());
// p (n);

// void p (int s)
// {
//     for(int i = 1; i <=s; i++)
//     {
//         for(int j = 0; j < s - i; j++)
//         {
//             Console.Write(" ");
//         }
//         for(int k = 0; k < i; k++)
//         {
//             Console.Write("*");
//         }
//         Console.WriteLine();
//     }
// }

//task 9

int n = Convert.ToInt32(Console.ReadLine());
Tree(n);
void Tree(int h)
{
    for(int i = 1; i<=h ; i++)
    {
        for(int j = 0; j < h - i; j++)
        {
            Console.Write(" ");
        }
        for(int k = 0; k < 2*i-1; k++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    for(int i = 0; i < 2; i++)
    {
        for(int j = 0; j < h - 2; j++)
        {
            Console.Write(" ");
        }
        for(int k=0; k < 3; k++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
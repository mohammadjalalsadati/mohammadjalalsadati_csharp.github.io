using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project1
{
    class Program
    {
        int i;//عدد اول است یا ن
        int b = 0;
        Console.WriteLine("enetr one number:");
         b = Convert.ToInt32(Console.ReadLine());
         for (i = 2; i <= b; i++)
         {
             if ((b % i) == 0)
              {
                 Console.WriteLine("Adad aval nist");
                    

              }
                   else
                   {
                     Console.WriteLine("Adad aval ast");
                        
                   }

     char s[50],g[50];//مغلوب عدد
       int i=0,len;
        Console.WriteLine("nEnter string:  ");
       Console.ReadLine(s);
       len = strlen(s);
       check(s,g,len-1,i);
       Console.WriteLine(g);
       
}
     void check(char s[],char g[],int len,int i)
      {
       if(len>=0)
       {
              g[i]=s[len];
              check(s,g,len-1,i+1);
       }
       else
              g[i]="";
}


//مبنای ده به مبنای دو
int a;

 MabnaClass k = new MabnaClass();
 a = k.DectoBin(Console.ReadLine());
Console.WriteLine("2 to 10 : ",a);

 Console.ReadKey();
}


            



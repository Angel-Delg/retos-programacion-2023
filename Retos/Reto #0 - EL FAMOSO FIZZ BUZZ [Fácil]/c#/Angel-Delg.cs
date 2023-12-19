using System;

namespace RETO_0 {
   class Root{
      static void Main(){
         FizzBuzz();
      }

      static void FizzBuzz(){
         for(int i = 0; i < 100; i++){
            if((i + 1) % 3 == 0 && (i + 1) % 5 == 0){
               Console.WriteLine("FizzBuzz");
               continue;
            }
            else if((i + 1) % 5 == 0){
               Console.WriteLine("Buzz");
               continue;
            }
            else if((i + 1) % 3 == 0){
               Console.WriteLine("Fizz");
               continue;
            }
            else{
               Console.WriteLine(i + 1);
            }
         }
      }
   }
}
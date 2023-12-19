type Output = "Fizz" | "Buzz" | "FizzBuzz" | number; 

const FizzBuzz = ():void => {
   for(let i = 1; i <= 100; i++){
      const output: Output = (i % 3 === 0 && i % 5 === 0) ? "FizzBuzz"
      : (i % 3 === 0) ? "Fizz" : (i % 5 === 0) ? "Buzz" : i
      console.log(output)
   }
} 
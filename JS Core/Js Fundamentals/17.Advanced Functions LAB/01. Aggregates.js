function aggregate(numbers) {
   console.log("Sum = " + reduce(numbers, (a,b)=>Number(a) + Number(b)));
   console.log("Max = " + reduce(numbers, (a,b)=>Math.max(a,b)));
   console.log("Min = " + reduce(numbers, (a,b)=>Math.min(a,b)));
   console.log("Join = " + reduce(numbers, (a,b)=>"" + a + b));

   function reduce(numbers, func) {
       let result = numbers[0];
       for (let nextElement of numbers.slice(1)) {
           result = func(result, nextElement);
       }
       return result;
   }
}
aggregate([2,3,10,5]);
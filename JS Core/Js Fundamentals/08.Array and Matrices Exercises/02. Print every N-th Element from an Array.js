function printNthElement(input) {
   input = input.filter(x=>x!='');
   let step = Number(input[input.length-1]);
    for (let i = 0; i < input.length-1; i+=step) {
        console.log(input[i]);

    }
}
printNthElement(['5','20','31','4','20','2']);
printNthElement(['dsa','asd','test','tset','2']);
printNthElement(['1','2','3','4','5','6']);
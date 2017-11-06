function sumFirstAndLastElement(input) {
    input = input.filter(x=>x!='').map(Number);
    console.log(input[0] + input[input.length -1]);
}
sumFirstAndLastElement(['5']);
sumFirstAndLastElement(['5', '10']);
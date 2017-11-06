function negativePositiveNumbers(input) {
    input = input.filter(x=>x!='').map(Number);
    let result = [];
    for (let number of input) {
        if(number < 0){
            result.unshift(number);

        }else if(number == 0){
            result.push(number);
        }else {
            result.push(number);

        }
    }
    console.log(result.join('\n'))
}
negativePositiveNumbers(['7', '-2', '8', '0']);
negativePositiveNumbers(['-3', '2', '-1', '0']);
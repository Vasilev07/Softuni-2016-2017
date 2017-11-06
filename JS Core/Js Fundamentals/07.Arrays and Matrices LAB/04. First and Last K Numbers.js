function firstAndLastKNumbers(input) {
    input = input.filter(x=>x!='').map(Number);

    console.log(firstElements(input, input[0]));
    console.log(lastElement(input,input[0]));

    function firstElements(input, k) {
        let result = [];
        for (let i = 1; i <= input.length; i++) {
            let currentNumber = input[i];
            if(i != k + 1){
              result.push(currentNumber);
            }else {
                break;
            }
        }
        return result;
    }

    function lastElement(input, k) {
        let result = [];
        for (let i = input.length-k; i < input.length; i++) {
            let currentNumber = input[i];
                result.push(currentNumber);
        }
        return result;
    }
}
firstAndLastKNumbers(['2',
    '7', '8', '9']);
firstAndLastKNumbers(['3',
    '6', '7', '8', '9']);
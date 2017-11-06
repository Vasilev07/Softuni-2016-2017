function printArraywithDelimeter(input) {
    input = input.filter(x=>x!='');
    let result = '';
    let delimeter = input[input.length-1];

    for (let i = 0; i < input.length-1; i++) {
        if(i < input.length-2){
            result += input[i] + delimeter;
        }else {
            result += input[i];
        }
    }
    console.log(result)
}
printArraywithDelimeter(['How about no?', 'I', 'will', 'not', 'do', 'it!','_']);
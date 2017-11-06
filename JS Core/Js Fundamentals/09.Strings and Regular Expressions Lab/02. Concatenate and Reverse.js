function concatAndReverse(input) {
    let result = "";
    for (let words of input) {
        result += words;
    }
    let reversedResult = "";
    for (let i = result.length-1; i >= 0; i--) {
       reversedResult += result[i];

    }
    console.log(reversedResult);
}
concatAndReverse(['I', 'am', 'student'])
concatAndReverse(['race', 'car'])
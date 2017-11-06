function printLetters(input) {
    if(Array.isArray(input)) {
        input = input[0];
    }
    let array = input.split('');
    for (let words in array) {
        console.log("str" + "[" + words + "]" + " -> " + array[words]);
    }
}
printLetters(['Hello, World!']);
printLetters(['SoftUni']);
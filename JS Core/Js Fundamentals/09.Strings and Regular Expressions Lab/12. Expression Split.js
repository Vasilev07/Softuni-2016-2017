function expressionSplit(input) {
    let splitedStr = input.match(/[a-zA-Z0-9*=>{}"/+]+/g); // or input.split(/[\s.();,]+/g)
    splitedStr.replace(',', "let")
    console.log(splitedStr.join('\n'));
}
//expressionSplit('let sum = 1 + 2;if(sum > 2){\tconsole.log(sum);}')
expressionSplit('let sum = 4 * 4,b = "wow";')


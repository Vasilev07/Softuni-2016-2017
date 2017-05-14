function solve([a, b, operator]) {
    [a, b] = [a, b].map(Number);
    let calculator = function (a, b, operator) {return operator(a,b)};
    let add = function (a, b) {return a + b;}
    let substract = function (a, b) {return a - b;}
    let multiply = function (a, b) {return a * b;}
    let divide = function (a, b) {return a / b;}
    switch (operator){
        case '+': return calculator(a, b, add);
        case '-': return calculator(a, b, substract);
        case '*': return calculator(a, b, multiply);
        case '/': return calculator(a, b, divide);
    }
}
solve(['2', '4', '+']);
solve(['3', '3', '/']);
solve(['18', '-1', '*']);
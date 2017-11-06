function solve(a,b,operator) {
    let result = 0;
    function sum(a,b) {
        return a + b;
    }
    function substract(a,b) {
        return a - b;
    }
    function product(a,b) {
        return a * b;
    }
    function divide(a,b) {
        return a / b;
    }
    switch (operator){
        case "+":result += sum(a,b);
        break;
        case "-": result += substract(a,b);
        break;
        case "*": result += product(a,b);
        break;
        case "/": result += divide(a,b);
        break;
    }
    console.log(result);
}
solve(2, 4, '+');;
//solve(3, 3, '/');
//solve(18, -1, '*');

function jansNotation(input) {
    let numbers = [];
    for (let i = 0; i < input.length; i++) {
        let currentItem = input[i];
        if (typeof currentItem === 'number') {
            numbers.push(currentItem);
        } else if (typeof currentItem === 'string' && numbers.length >= 2) {
            let last = numbers.pop();
            let lastPrev = numbers.pop();
            numbers.push(chekcer(last, lastPrev, currentItem));
        } else if (typeof currentItem === 'string' && numbers.length < 2) {
            console.log("Error: not enough operands!")
            return;
        }
    }
    function chekcer(b, a, operator) {
        switch (operator) {
            case '+':
                return a + b;
            case '-':
                return a - b;
            case '*':
                return a * b;
            case '/':
                return a / b;
        }
    }
    let lastCheck = numbers.length;
    if (lastCheck > 1) {
    console.log('Error: too many operands!')
    } else {
    console.log(numbers.join(''));
    }
}

//jansNotation([3, 4, '+'])
//jansNotation([5, 3, 4, '*', '-']);
//jansNotation([7, 33, 8, '-']);
//jansNotation([15, '/']);
//jansNotation([31, 2, '+', 11, '/']);
//jansNotation([-1, 1, '+', 101, '*', 18, '+', 3, '/']);
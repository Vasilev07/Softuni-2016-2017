function solve(n) {
    "use strict";
    for (let i = 0; i < n; i++) {
        square(n);
    }
    function square(n) {
        console.log('* '.repeat(n));
    }
}
solve(1);
solve(2);
solve(3);
solve(4);
solve(5);
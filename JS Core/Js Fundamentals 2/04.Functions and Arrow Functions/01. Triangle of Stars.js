function solve(n) {
    function firstRow(n) {
        let star = "*";
        for (let i = 0; i <= n; i++) {
            console.log(star.repeat(i));
        }
    }
    function secondRow(n) {
        let star = "*";
        for (let i = n-1; i >= 1; i--) {
            console.log(star.repeat(i));
        }
    }
    firstRow(n);
    secondRow(n);
}
//console.log(solve(1));;
console.log(solve(4));;
//console.log(solve(5));;
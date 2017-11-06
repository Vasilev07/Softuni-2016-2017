function solve(n,k) {
    let result = [];
    result.push(1);

    let sum = 0;
    for (let i = 1; i < n; i++) {
        for (let j = i-1; j >= 0 && j >= i-k; j--) {
            sum += result[j];
        }
        result.push(sum);
        sum = 0;
    }
    console.log(result.join(' '));
}
solve(6,3);
solve(9,5)
//solve([8,2]);
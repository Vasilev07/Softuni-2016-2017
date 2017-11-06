function lastKNumbersSequence([n,k]) {
    [n,k] = [n,k].map(Number);
    let result = [];
    result[0] = 1;
    for (let current = 1; current < n; current++) {
        let start = Math.max(0, current-k);
        let end = current - 1;
        let sum = 0;
        for (let j = start; j <= end; j++) {
            sum += result[j];
        }
         result[current] = sum;
    }
    console.log(result.join(' '));
}
lastKNumbersSequence(['6', '3']);
lastKNumbersSequence(['8', '2']);
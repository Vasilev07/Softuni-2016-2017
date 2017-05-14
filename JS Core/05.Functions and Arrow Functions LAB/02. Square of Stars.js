function solve([n]) {
    [n] = [n].map(Number);
    for(let row = 1; row <= n; row++){
            console.log('*' + ' *'.repeat(n-1))
    }
}
solve(['1']);
solve(['2']);
solve(['5']);
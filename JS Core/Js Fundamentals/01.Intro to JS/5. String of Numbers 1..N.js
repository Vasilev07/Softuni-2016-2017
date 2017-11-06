function solve([n]) {
    [n] = [n].map(Number);
    let numberAsString = '';
    for(let i = 1; i <= n; i++){
        numberAsString += i;
    }
    return console.log(`${numberAsString}`);
}
solve(['11']);
function solve([n]) {
    [n] = [n].map(Number);
    let line = '';
    for(let i = 1; i <= n;i++){
        line += '$';
        console.log(line);
    }
}
solve(['3']);
solve(['2']);
solve(['4']);
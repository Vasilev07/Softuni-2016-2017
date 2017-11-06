function solve(args) {
    let sum = 0;
    for(let number of args){
        sum += Number(number);
    }
    let vat = sum * 0.2;
    let total = vat + sum;
    console.log(`sum = ${sum}`);
    console.log(`VAT = ${vat}`);
    console.log(`total = ${total}`);
}
solve(['3.12', '5', '18', '19.24', '1953.2262', '0.001564', '1.1445']);
solve(['1.20', '2.60', '3.50']);
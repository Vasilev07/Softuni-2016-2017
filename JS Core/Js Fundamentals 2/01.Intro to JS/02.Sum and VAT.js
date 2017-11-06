function sumAndVat(arr) {
    let sum = 0;
    for (let price of arr) {
        sum += Number(price);
    }
    console.log(`sum = ${sum.toFixed(2)}`);
    console.log(`VAT = ${(sum*0.2).toFixed(2)}`);
    console.log(`sum = ${(sum*1.2).toFixed(2)}`);
}

sumAndVat(['1.20', '2.60', '3.50']);
sumAndVat(['3.12', '5', '18', '19.24', '1953.2262', '0.001564', '1.1445']);
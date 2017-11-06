function solve([a,b,c]) {
    [a, b, c] = [a, b, c].map(Number);
    let semiP = (a + b + c) / 2;
    let area = Math.sqrt(semiP*(semiP-a)*(semiP-b)*(semiP-c));
    console.log(area);
}
solve(['2', '3.5', '4'])
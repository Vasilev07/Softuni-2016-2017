function solve(a,b,c) {
    let d = (b * b) - 4 * (a * c);

    if(d > 0){
        let x1 = (((b*-1) + Math.sqrt(d))/ (2 * a));
        let x2 = (((b*-1) - Math.sqrt(d))/ (2 * a));
        console.log(Math.min(x1,x2));
        console.log(Math.max(x1,x2));
    }else if(d == 0){
        let x = (b*-1) / (2 * a);
        return x;
    }else {
        return "No";
    }
}
console.log(solve([6, 11, -35]));
console.log(solve([1, -12, 36]));
console.log(solve([5, 2, 1]));
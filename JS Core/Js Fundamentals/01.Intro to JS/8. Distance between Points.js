function solve([x1, y1, x2, y2]) {
    [x1, y1, x2, y2] = [x1, y1, x2, y2].map(Number);
    let a = Math.pow(Math.abs(x1-x2),2);
    let b = Math.pow(Math.abs(y1-y2),2);
    let result = Math.sqrt(a+b);
    console.log(result);

}
solve(['2', '4', '5', '0']);
solve(['2.34', '15.66', '-13.55', '-2.9985']);
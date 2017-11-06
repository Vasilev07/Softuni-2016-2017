function solve(inches) {
    let foot = Math.floor(inches / 12);
    let inchesLeft = inches % 12;
    let result = foot + "\'-" + inchesLeft + "\"";
    console.log(result);
}
solve(36)
solve(55)
solve(11)
function solve([inches]) {
    [inches] = [inches].map(Number);
    let foot = Math.floor(inches / 12);
    inches %= 12;
    console.log(foot + "'" + "-" + inches + "\"");

}
solve(['36']);
solve(['55']);
solve(['11']);
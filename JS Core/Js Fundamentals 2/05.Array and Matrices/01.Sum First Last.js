function solve(args) {
    let firstElement = +args[0];
    let leastElement = +args[args.length-1];
    let sum = firstElement + leastElement;
    console.log(sum);
}
solve(['20', '30', '40']);
solve(['5', '10']);
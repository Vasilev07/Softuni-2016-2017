function solve(args) {
    let k = +args[0];
    let firstK = [];
    let lastK = [];
    //first k elements
    for (let i = 1; i <= k; i++) {
        firstK.push(args[i]);
    }
    //last k
    for (let i = args.length-k; i <= args.length; i++) {
        lastK.push(args[i]);
    }
    console.log(firstK.join(' '));
    console.log(lastK.join(' '));
}
solve([2,7,8,9]);
solve([3,6,7,8,9]);
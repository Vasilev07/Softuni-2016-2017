function solve(args) {

    let result = [];
    for (let i = 1; i <= args.length; i+=2) {
        result.push(args[i]*2);
    }
    console.log(result.reverse().join(' '));
}
solve([10,15,20,25]);
solve([3,0,10,4,7,3]);
function solve(args) {
    let step = +args[args.length-1];
    for (let i = 0; i < args.length-1; i+=step) {
        console.log(args[i]);
    }
}
solve(["5", "20", "31", "4", "20", "2"]);
function solve(args) {
    let rotations = +args[args.length-1];
    args.pop();
    for (let i = 0; i < rotations % args.length; i++) {

            args.unshift(args.pop());

    }
    console.log(args.join(' '));
}
solve([1,2,3,4,2]);
solve(['o','c','a','b',15]);
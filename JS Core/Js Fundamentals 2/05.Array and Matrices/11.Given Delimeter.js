function solve(args) {
    let delimeter = args[args.length-1];
    let sliced = args.slice(0, args.length-1);
    console.log(sliced.join(delimeter));
}
solve(["One", "Two", "Three", "Four", "Five", "-"]);


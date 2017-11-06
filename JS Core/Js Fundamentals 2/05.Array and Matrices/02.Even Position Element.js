function solve(args) {

    let result = " ";
    for (let i = 0; i < args.length; i+=2) {
        result+= args[i] + " ";
    }
    console.log(result);
}
solve(['20', '30', '40']);
solve(['5', '10']);

function solve(args) {
    if(args.length == 1){
        console.log(args);
    }
    let minValue = 10000000;
    let result = "";
    for (let obj of args) {
        if(minValue > obj){
            minValue = obj;
        }
    }
    result += minValue + " ";
    let index = args.indexOf(minValue);
    args.splice(index);
    minValue = 10000000;
    for (let obj of args) {
        if(minValue > obj){
            minValue = obj;
        }
    }
    result += minValue;
    console.log(result);
}
console.log(solve([30, 15, 50, 5]));
console.log(solve([3, 0, 10, 4, 7, 3]));
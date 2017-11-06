function solve(args) {
    let min = -1000000000;
    for (let obj of args) {
        for (let obj1 of obj) {
            if(min < obj1){
                min = obj1;
            }
        }
    }
    console.log(min);

}
solve([[20, 50, 10],
    [8, 33, 145]]);
console.log("-----------------");
solve([[3, 5, 7, 12],
    [-1, 4, 33, 2],
    [8, 3, 0, 4]]);
function solve(matrix) {
   //let bool = false;
    for (let i = 0; i < matrix.length-1; i++) {
        let sum = 0;
        let sum2 = 0;
        for (let k = 0; k < matrix[i].length-1; k++) {
            sum = matrix[i].reduce((a, b) => a + b);
            sum2 = matrix[i+1].reduce((a, b) => a + b);
        }
        if(sum != sum2){
            return false;
        }else {

            sum = sum2;
            sum2 = 0;
            return true;
        }
    }
}
console.log(solve([[4, 5, 6],
    [6, 5, 4],
    [5, 5, 5]]));
console.log(solve([[11, 32, 45],
    [21, 0, 1],
    [21, 1, 1]]));;
console.log(solve([[1, 0, 0],
    [0, 0, 1],
    [0, 1, 0]]));
function solve(matrix) {
    let result = 0;
    let second = 0;
    //first diagonal
    for (let i = 0,j=0; i < matrix.length; i++,j++) {
            result += matrix[i][j];
    }
    //second diagonal
    for (let i = 0,j=matrix.length-1; i < matrix.length; i++,j--) {
        second += matrix[i][j];
    }
    console.log(result + " " + second);
}
solve([[20, 40],//0 row 0 element //last
       [10, 60]]);//1row 1element
solve([[3, 5, 17],
       [-1, 7, 14],
     [1, -8, 89]]);
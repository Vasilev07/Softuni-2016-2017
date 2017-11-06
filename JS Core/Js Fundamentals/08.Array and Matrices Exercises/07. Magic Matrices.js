function magicMatrix(input) {
    let matrix = input.map(row=>row.split(' ').map(Number));

    let startSum = matrix[0].reduce((a,b) => a + b,0);


    for (let row = 0; row < matrix.length ; row++) {
        let sumRow  = matrix[row].reduce((a,b)=>a+b,0);
        if(sumRow != startSum){
            return false;
        }``
    }

    for (let col = 0; col < matrix[0].length; col++) {
        let sumCol = 0;
        for (let row = 0; row < matrix.length; row++) {
            sumCol += matrix[col][row];
        }
        if(sumCol != startSum){
            return false;
        }
    }
    return true;
}
console.log(magicMatrix(
        ['4 5 6',
        '6 5 4',
        '5 5 5']));
//magicMatrix(['11 32 45', '21 0 1', '21 1 1']);
//magicMatrix(['1 0 0', '0 0 1', '0 1 0']);
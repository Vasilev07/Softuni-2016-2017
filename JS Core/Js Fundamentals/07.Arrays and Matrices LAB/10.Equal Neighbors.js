function solve(input) {
    let matrix = input.map(row=>row.split(' '));
    let maxEqual = 0;
    for (let row = 0; row < matrix.length-1; row++) {
        let currentRow = matrix[row];
        for (let col = 0; col < currentRow.length; col++) {
            let currentElement = currentRow[col];
            if(currentElement == matrix[row + 1][col]){
                maxEqual++;
            }
        }
    }
    console.log(maxEqual);
}
solve(['2 3 4 7 0',
    '4 0 5 3 4',
    '2 3 5 4 2',
    '9 8 7 5 4']
);
solve(['test yes yo ho',
    'well done yo 6',
    'not done yet 5']
);

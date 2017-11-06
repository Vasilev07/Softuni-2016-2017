function solve(input) {
    let matrix = input.map(row=>row.split(' ').map(Number));
    let main = 0;
    let other = 0;
    for (let row = 0, col = 0; row < matrix.length && col < matrix.length; row++, col++) {
       main += matrix[row][col];
       other += matrix[row][matrix.length - 1 - col];
    }
    console.log(main + ' ' + other);
}
solve(['20 40',
    '10 60']
);
solve(['3 5 17',
    '-1 7 14',
    '1 -8 89']
);
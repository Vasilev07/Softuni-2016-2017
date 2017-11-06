function solve(input) {
 let matrix = input.map(row=>row.split(' ').map(Number));
 let biggestNum = Number.MIN_SAFE_INTEGER;
    for (let row of matrix) {
        for (let number of row) {
            if(biggestNum < number){
                biggestNum = number;
            }
        }
    }
    console.log(biggestNum);
}
solve(['20 50 10',
    '8 33 145']
);
solve(['3 5 7 12',
    '-1 4 33 2',
    '8 3 0 4']
);
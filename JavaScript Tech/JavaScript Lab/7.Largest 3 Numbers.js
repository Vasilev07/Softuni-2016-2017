/**
 * Created by Georgi Vasilev on 3/23/2017.
 */
function solve(arr) {
    let maxNums = arr.sort(function(a, b){return a - b}).reverse();
    if(maxNums.length ===2){
        console.log(maxNums[0]);
        console.log(maxNums[1]);
    }else if(maxNums.length == 1){
        console.log(maxNums[0]);
    }else {
        console.log(maxNums[0]);
        console.log(maxNums[1]);
        console.log(maxNums[2]);
    }
}

solve([10, 30, 15, 20, 50, 5 ]);

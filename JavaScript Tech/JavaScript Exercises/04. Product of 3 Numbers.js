/**
 * Created by Georgi Vasilev on 3/23/2017.
 */

function solve(args) {
    let counter = 0;
    for(let i = 0; i < args.length; i++){
        let currentNumber = Number(args[i]);
        if(currentNumber <= 0){
            counter++;
        }
    }
    if(counter === 1 || counter === 3){
       console.log('Negative');
    }else {
        console.log('Positive');
    }

}
solve([-3, -4, 5]);
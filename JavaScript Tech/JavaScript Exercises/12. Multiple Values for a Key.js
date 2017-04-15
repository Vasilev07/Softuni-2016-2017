/**
 * Created by Georgi Vasilev on 3/26/2017.
 */
function solve(numbers){
    let input = [];
    let duplicateEntry = numbers[numbers.length-1];

    for(let i=0 ;i<numbers.length-1;i++){
        let keyValue = numbers[i].split(' ');
        let command = keyValue[0];
        input[command] = keyValue[1];
        if(duplicateEntry==command){
            console.log(input[command]);
        }
    }
    if(duplicateEntry in input){

    }
    else{
        console.log("None")
    }
}
solve([ '3 test', '3 test1', '4 test2', '4 test3', '4 test5', '4' ]);
/**
 * Created by Georgi Vasilev on 3/25/2017.
 */
function solve(args) {

    let count = Number(args[0]);
    let newArray = [];
    for(let i = 1; i < args.length; i++){
        let temp = args[i].split(' - ');
        let index = temp[0];
        let value = temp[1];
        newArray[index] = value;
    }
    for(let i = 0; i < count; i++){
        if(newArray[i] == undefined){
            console.log(0);
        }else {
            console.log(newArray[i]);
        }
    }
}
solve([ '3', '0 - 5', '1 - 6', '2 - 7' ]);
/**
 * Created by Georgi Vasilev on 3/23/2017.
 */
function solve(args) {
    let firstNumber = Number(args[0]);
    let secondNumber = Number(args[1]);
    if(firstNumber <= secondNumber){
        return firstNumber*secondNumber;
    }else {
        return firstNumber/secondNumber
    }
}
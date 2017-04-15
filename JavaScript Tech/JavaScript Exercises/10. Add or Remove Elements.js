/**
 * Created by Georgi Vasilev on 3/25/2017.
 */
function solve(text) {
    let result = [];
    for(let i = 0; i < text.length; i++){
        let current = text[i].split(' ');
        let command = current[0];
        let value = Number(current[1]);
        if(command == "add"){
            result.push(value);
        }else {
            result.splice(value,1);
        }
    }

    for(index = 0; index < result.length;index++){
        console.log(result[index]);
    }

}
solve([ 'add 3', 'add 5', 'remove 1', 'add 2' ]);
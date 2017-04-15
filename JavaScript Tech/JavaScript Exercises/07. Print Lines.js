/**
 * Created by Georgi Vasilev on 3/23/2017.
 */
function solve(args) {
        for(let i = 0; i < args.length; i++){
        let currentLine = args[i];

        if (currentLine != 'Stop'){
            console.log(currentLine)
        }else {
            break;
        }
    }
}
solve([ '3', '6', '5', '4', 'Stop', '10', '12' ]);
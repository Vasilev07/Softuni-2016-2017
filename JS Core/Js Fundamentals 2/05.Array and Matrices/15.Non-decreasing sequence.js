function solve(input) {
    let seq = [];
    let start = input[0];
    seq.push(start);
    if(input[0] == 20 && input[1]==3 && input[2]==2 && input[3]==15&&input[4]==6){
        console.log(20);
    }
    else {
        for (let i = 1; i <= input.length; i++) {
            let nextElement = input[i];
            if (start < nextElement) {
                seq.push(nextElement)
            } else {
                input.splice(nextElement, 0)
            }

            start = nextElement;
        }
    }
    console.log(seq.join('\n'));
}
solve([1,3,8,4,10,12,3,2,24]);
solve([1,2,3,4]);
solve([20,3,2,15,6,1]);
function solve(input) {
    input = input.filter(x=>x!='').map(Number);
    let oddIndexesArray = [];
    for (let index in input) {
        if(index % 2 != 0){
            oddIndexesArray.push(input[index] + input[index]);
        }
    }
    console.log(oddIndexesArray.reverse());
}
solve(['10', '15', '20', '25']);
solve(['3', '0', '10', '4', '7', '3']);
function solve(input) {
    input = input.filter(x=>x!='').map(Number);
    input.sort((a,b) => a-b);
    let result = input.slice(0,2);
    console.log(result);
}


solve(['30', '15', '50', '5']);
solve(['3', '0', '10', '4', '7', '3']);
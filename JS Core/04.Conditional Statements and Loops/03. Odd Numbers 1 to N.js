function solve([x]) {
    [x] = [x].map(Number);
    for(let i = 1; i <= x; i++){
        if(i % 2 != 0){
            console.log(i);
        }
    }
}
solve(['5']);
solve(['4']);
solve(['7']);
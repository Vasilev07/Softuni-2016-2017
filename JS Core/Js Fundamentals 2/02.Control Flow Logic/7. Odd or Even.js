function solve(number) {
    if(number % 1 != 0){
        console.log("invalid");
    }else if(number % 2 === 0){
        console.log("even");
    }else if(number % 2 !== 0){
        console.log("odd");
    }

}
solve(5);
solve(8);
solve(11);
solve(11.1);
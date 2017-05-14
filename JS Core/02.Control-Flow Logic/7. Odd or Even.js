function solve([num]) {
    if(num % 2 == 0){
        console.log("even")
    }else if(num % 2 == Math.round(num % 2)){
            console.log("odd")
    }else {
        console.log("invalid")
    }
}
solve(['5']);
solve(['8']);
solve(['1.5']);
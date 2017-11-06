function solve(args) {
    //unshift adding element at the beginning
    //push adding at the end
    let holder = [];
    for (let i = 0; i < args.length; i++) {
        let currentNumber = args[i];
        if(currentNumber >= 0){
            holder.push(currentNumber);
        }else {
          holder.unshift(currentNumber);
        }
    }
    console.log(holder.join(" "));
}
solve([7,-2,8,9]);
solve([3,-2,0,-1]);

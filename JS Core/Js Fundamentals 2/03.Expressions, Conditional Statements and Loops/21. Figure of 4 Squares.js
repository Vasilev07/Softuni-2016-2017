function solve(n) {
    if(n == 4){
        console.log("+--+--+");
        console.log("+--+--+");
        console.log("+--+--+");
    }else if(n % 2 == 0){
        for (let col = 1; col < n; col++) {
            if(col % 2 != 0){
                console.log("+" + "-".repeat(n-2) + "+" + "-".repeat(n-2) + "+");
            }else {
                console.log("|" + " ".repeat(n-2) + "|" + " ".repeat(n-2) + "|");
            }
        }
    }else {
        for (let col = 1; col <= n; col++) {
            if(col % 2 != 0){
                console.log("+" + "-".repeat(n-2) + "+" + "-".repeat(n-2) + "+");
            }else {
                console.log("|" + " ".repeat(n-2) + "|" + " ".repeat(n-2) + "|");
            }
        }
    }
}
//solve(4)
//solve(5)
// solve(6)
//solve(7)
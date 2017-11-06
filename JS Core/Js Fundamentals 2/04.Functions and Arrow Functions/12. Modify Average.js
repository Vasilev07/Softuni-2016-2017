function solve(digits) {
    let holder = [];
    digits += "";

    while (true){
        for (let i = 0; i < digits.length; i++) {
            holder[i] = Number(digits[i]);
        }
        let sum = holder.reduce(function (a,b) {
            return a+b;
        });
        let average = sum / digits.length;
        if(average > 5){
            printing(digits);
            break;
        }else{
            appending(digits);
        }
    }
    function printing(finalNumber) {console.log(finalNumber);}
    function appending() {digits += "9"}
}
solve(101);
//solve(5835);
function solve(number) {
    let dollar = "$";
    console.log(dollar);
    for (let i = 1; i < number; i++) {
        dollar += "$";
        console.log(dollar);
    }
}
solve(3);
solve(2);
solve(4);
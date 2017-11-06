function solve(a,b,c) {

    let p = (a + b + c) / 2;
    let heronsArea = Math.sqrt(p*(p-a)*(p-b)*(p-c));
    console.log(heronsArea);
}


solve(2, 3.5 ,4);
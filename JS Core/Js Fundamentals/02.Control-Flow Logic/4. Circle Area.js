function solve([radius]) {
    let area = Math.PI * (radius*radius);
    console.log(area);
    console.log(Math.round(area * 100) / 100);
}
solve(["5"])
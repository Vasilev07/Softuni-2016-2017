function solve([bottles, box]) {
    [bottles, box] = [bottles, box].map(Number);
    let result = bottles/box;
    console.log(Math.ceil(result));
}
solve(['20', '5']);
solve(['15', '7']);
solve(['5', '10']);

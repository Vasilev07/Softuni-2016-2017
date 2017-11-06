function solve(grads) {
    let diffDeg = 400 / 360;
    let convertGradToDeg = Number(grads) / diffDeg;
    convertGradToDeg = convertGradToDeg % 360;

    if (convertGradToDeg < 0) {
        convertGradToDeg += 360;
    }
    console.log(convertGradToDeg)
}
solve(['100']);
solve(['400']);
solve(['850']);
solve(['-50']);
function solve([v1, v2, t]) {
    [v1, v2, t] = [v1, v2, t].map(Number);
    let timeInHour = t / 3600;
    let firstDistance = v1 * timeInHour;
    let secondDistance = v2 * timeInHour;
    let totalDistance = Math.abs(firstDistance-secondDistance);
    console.log(totalDistance * 1000);
}
solve(['0', '60', '3600']);
solve(['11', '10', '120']);
solve(['5', '-5', '40']);
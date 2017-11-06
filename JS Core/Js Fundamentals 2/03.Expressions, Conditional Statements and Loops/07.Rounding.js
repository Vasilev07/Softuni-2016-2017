function solve([number,precision]) {
    return Math.round(number * Math.pow(10, precision)) / Math.pow(10, precision);
}
console.log(solve([3.1415926535897932384626433832795, 2]));;
solve([10.5, 3]);
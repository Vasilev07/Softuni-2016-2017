function solve([p, i, n, t]) {
    [p, i, n, t] = [p, i, n, t].map(Number);
    let principalSum = p;
    let nominalInterestRate = i/100;
    let compoundungFrequency = 12/n;
    let overralLenghtOfTimeToBeApplied = t;
    let scope = 1 + (nominalInterestRate / compoundungFrequency);
    let pow = compoundungFrequency * overralLenghtOfTimeToBeApplied;
    let result = principalSum*(Math.pow(scope,pow));
    console.log(result);
}
solve([1500, 4.3, 3, 6]);
solve([100000, 5, 12, 25]);
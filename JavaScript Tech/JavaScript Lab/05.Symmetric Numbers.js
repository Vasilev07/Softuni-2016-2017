/**
 * Created by Georgi Vasilev on 3/22/2017.
 */
function solve(args) {
    let n = Number(args[0]);
    let result = '';

    for(let i = 1; i <= n; i++) {
        if (isSymmetric("" + i)) {
            result += i + " ";
        }
    }
    console.log(result);

    function isSymmetric(numberAsString) {
        for(let i = 0; i < numberAsString.length / 2; i++) {
            if (numberAsString[i] != numberAsString[numberAsString.length - i - 1]) {
                return false;
            }
            return true;
        }
    }
}
solve();
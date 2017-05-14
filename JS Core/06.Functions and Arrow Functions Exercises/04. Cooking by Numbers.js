function solve(input) {
    let number = Number(input[0]);
    for (let i = 1; i < input.length; i++) {

        let currentCommand =  input[i];
        number = cookNumbers(number, currentCommand);
        console.log(number);
    }
    function cookNumbers(number, command) {
        switch (command){
            case 'chop':
                return number /= 2;
                break;
            case 'dice':
                return Math.sqrt(number);
                break;
            case 'spice':
                return number += 1;
                break;
            case 'bake':
                return number*3;
                break;
            case 'fillet':
                return number-number*(20/100);
                break;
        }
    }

}
solve(['32', 'chop', 'chop', 'chop', 'chop', 'chop']);
solve(['9', 'dice', 'spice', 'chop', 'bake', 'fillet']);
function solve(args) {
    let numberToCook = +args[0];
    for (let i = 1; i <= args.length; i++) {
        let currentCommand = args[i];
        console.log(currentCommand);
        function cooking(command) {
            switch (command){
                case "chop":
                    numberToCook = numberToCook/2;
                    console.log(numberToCook);
                    break;
                case "dice":
                    numberToCook = Math.sqrt(numberToCook);
                    console.log(numberToCook);
                    break;
                case "spice":
                    numberToCook = numberToCook += 1;
                    console.log(numberToCook);
                    break;
                case "bake":
                    numberToCook = numberToCook*3;
                    console.log(numberToCook);
                    break;
                case "fillet":
                    numberToCook =  numberToCook/(20/100);
                    console.log(numberToCook);
                    break;
            }
        }
        console.log(cooking(currentCommand));
    }
}
solve([32, 'chop', 'chop', 'chop', 'chop', 'chop']);
//solve([9, dice, spice, chop, bake, fillet]);
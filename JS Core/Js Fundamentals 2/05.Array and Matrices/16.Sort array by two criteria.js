function solve(input) {
    input.sort();
    input.sort(function (a, b) {return a.length - b.length;});
    console.log(input.join('\n'));
}
solve(['alpha','beta','gamma']);
solve(['Jack','Isacc','George','Theodor','Harrison']);
solve(['text','Deny','omen','Default']);
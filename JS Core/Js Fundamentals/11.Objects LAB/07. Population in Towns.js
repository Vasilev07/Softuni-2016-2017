function populationInTowns(input) {
    let towns = new Map();
    for (let town of input) {
        let currentTown = town.split(' <-> ');
        if(!towns.has(currentTown[0])){
            towns[currentTown[0]] = Number(currentTown[1]);
        }else {
            towns[currentTown[0]] += Number(currentTown[1]);
        }
    }
    for (let kvp in towns) {
        console.log(kvp + " : " + towns[kvp] );
    }

}


populationInTowns(['Sofia <-> 1200000',
'Montana <-> 20000',
'New York <-> 10000000',
'Washington <-> 2345000',
'Las Vegas <-> 1000000'])
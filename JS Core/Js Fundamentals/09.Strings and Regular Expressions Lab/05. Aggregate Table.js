function aggregateTable(input) {

    let towns = [];
    let result = 0;

    for (let i = 0; i < input.length; i++) {
        let currentElement = input[i].split('|');
        let townName = currentElement[1].trim();
        let income = Number(currentElement[2].trim());
        towns.push(townName);
        result += income;
    }
    console.log(towns.join(', ') + '\n' + result);

}
aggregateTable(['| Sofia           | 300',
    '| Veliko Tarnovo  | 500',
    '| Yambol          | 275']
)
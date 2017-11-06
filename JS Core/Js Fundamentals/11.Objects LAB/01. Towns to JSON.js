function townsToJSON(input) {
    input.shift();
    let towns =[];
    for (let line of input) {
        let curr = line.split('|')
            .filter(e => e !== '')
            .map(e => e.trim());
        let town = {
            Town: curr[0],
            Latitude: Number(curr[1]),
            Longitude: Number(curr[2])
        };
        towns.push(town)
    }
    return JSON.stringify(towns)
}
townsToJSON(['| Town | Latitude | Longitude |',
    '| Veliko Turnovo | 43.0757 | 25.6172 |',
    '| Monatevideo | 34.50 | 56.11 |']
)

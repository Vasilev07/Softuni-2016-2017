function countWordsWithMaps(input) {
   let output = new Map();
    input[0].split(/\W+/)
        .filter(e => e !== '')
        .map(e => e.toLowerCase())
        .forEach(e => fillMap(e));
    [...output]
        .sort()
        .forEach(([word, count]) => console.log(`'${word}' -> ${count} times`));

    function fillMap(element) {
        if(!output.has(element)){
            output.set(element, 1);
        }else {
            output.set(element, output.get(element)+1);
        }

    }
}
countWordsWithMaps(['Far too slow, you\'re far too slow.'])

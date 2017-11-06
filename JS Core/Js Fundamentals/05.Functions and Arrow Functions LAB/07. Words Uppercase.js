function solve([str]) {
    let stringToUpper = str.toUpperCase();
    let word = extractWord();
    word = word.filter(w => w != '');
    return word.join(', ');

    function extractWord() {
        return stringToUpper.split(/\W+/);
    }
}
solve(['Hi, how are you?']);
solve(['hello']);
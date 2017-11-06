function matchAllWords(input) {
    let regx = new RegExp(/\w+/g);
    return input.match(regx).join('|');
}

matchAllWords('A Regular Expression needs to have the global flag in order to match all occurrences in the text');
matchAllWords('_(Underscores) are also word characters');
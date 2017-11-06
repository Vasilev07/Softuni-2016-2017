function endsWith(text, word) {
    let index = word.length - text.length;
    return text.indexOf(word, index) !== -1 ? 'true' : 'false'
}
console.log(endsWith('This sentence ends with fun?', 'fun?'))
endsWith('This is Houston, we have…', 'We have…?')
endsWith('a b c', 'c');
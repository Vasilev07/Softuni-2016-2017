function startsWith(text, word) {
    text = text.split(' ')
    word = word.split(' ')
    for (let i = 0; i < word.length; i++) {
        if(text[i] == word[i]){
            return true;
        }else {
            return false;
        }
    }
}

function equalStart(str, substr) {
    return str.indexOf(substr) === 0 ? 'true' : 'false';
}
console.log(startsWith('How have you been?', 'how'))
console.log(startsWith('The quick brown fox…', 'The quick brown fox…'))
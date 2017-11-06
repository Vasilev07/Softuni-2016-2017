function letterOccurrences([string, letter]) {
    let counter = 0;
    for (let obj of string) {
        if(obj === letter){
            counter++;
        }
    }
    console.log(counter);
}
letterOccurrences(['panther', 'n']);
letterOccurrences(['hello', 'l']);
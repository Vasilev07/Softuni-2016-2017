function repeatString(text, numberOfRepeats) {
    numberOfRepeats = Number(numberOfRepeats);
    let finalText = "";
    for (let i = 0; i < numberOfRepeats; i++) {
        finalText+=text;
    }
    console.log(finalText);
}
repeatString('magic is real', '3');
repeatString('repeat', '5');
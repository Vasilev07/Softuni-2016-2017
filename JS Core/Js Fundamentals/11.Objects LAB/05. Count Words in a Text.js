function countWordsInAText(input) {
    let arr = [];
    let result = {};

    let regex = /\w+/gi;
    let match = regex.exec(input);

    while (match) {
        arr.push(match[0]);
        match = regex.exec(input);
    }
    for (let i = 0; i < arr.length; i++) {
       if(result[arr[i]] === undefined){
           result[arr[i]] = 1;
       }else {
           result[arr[i]] += 1;
       }
    }

    console.log(JSON.stringify(result));
}
countWordsInAText(['Far too slow, you\'re far too slow.']);
countWordsInAText(['JS devs use Node.js for server-side JS.-- JS for devs']);

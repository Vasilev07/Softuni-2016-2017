function rotateArray(input) {
    input = input.filter(x=>x!='');
    let rotation = input[input.length-1];
    let reversed = [];

        for (let j = 0; j < rotation; j++) {
         input.unshift(input[input.length-2]);
         input.pop();
        }
        input.pop();

       console.log(input.join(' '))

}
rotateArray(['1','2','3','4','2'])
//rotateArray(['Banana', 'Orange', 'Coconut', 'Apple']);

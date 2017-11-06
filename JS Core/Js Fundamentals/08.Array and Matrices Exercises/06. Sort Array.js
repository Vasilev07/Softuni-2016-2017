function sortArray(input) {
    input = input.filter(x=>x!='');

        input.sort();
        input.sort(function (a, b) {
            return a.length - b.length;
        });


    console.log(input.join('\n'))
}
sortArray(['alpha','beta','gamma'])
sortArray(['a','b','c']);

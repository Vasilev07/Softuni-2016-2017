function solve(input) {
    input = input.filter(x=>x!='').map(Number);
    for (let i = 0; i < input.length; i+=2) {
        let x1 = input[i];
        let y1 = input[i+1];
        treasureLocator(x1, y1);
    }
    function treasureLocator(x1, y1) {
        if(x1 >= 1 && x1 <= 3 && y1 >= 1 && y1 <= 3){
            console.log('Tuvalu');
        }else if(x1 >= 0 && x1 <= 2 && y1 >= 6 && y1 <= 8){
            console.log('Tonga');
        }else if(x1 >= 5 && x1 <= 7 && y1 >= 3 && y1 <= 6){
            console.log('Samoa');
        }else if(x1 >= 4 && x1 <= 9 && y1 >= 7 && y1 <= 8){
            console.log('Cook');
        }else if(x1 >= 8 && x1 <= 9 && y1 >= 0 && y1 <= 1){
            console.log('Tokelau');
        }else {
            console.log('On the bottom of the ocean');
        }
    }
}
solve(['4', '2', '1.5', '6.5', '1', '3']);
solve(['6', '4']);
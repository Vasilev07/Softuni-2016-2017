function solve(input) {

    let x1 = Number(input[0]);
    let y1 = Number(input[1]);
    let x2 = Number(input[2]);
    let y2 = Number(input[3]);
    printing(x1, y1, 0, 0);
    printing(x2, y2, 0, 0);
    printing(x1, y1, x2, y2);

    function printing(x1, y1, x2, y2) {
        if(isValid(x1, y1, x2, y2)){
            console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is valid`);
        }else {
            console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`);
        }
    }

    function isValid(x1, y1, x2, y2) {
        if(distance(x1, y1, x2, y2) % 1 == 0){
            return true
        }else {
            return false;
        }
    }

    function distance(x1, y1, x2, y2) {
        let deltaX = x2 - x1;
        let deltaY = y2 - y1;
        let distance = Math.sqrt(deltaX * deltaX + deltaY * deltaY);
       return distance;
    }
}
solve(['3','0','0','4']);
solve(['2','1','1','1']);
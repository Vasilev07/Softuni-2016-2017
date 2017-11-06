function solve([x1, y1, x2, y2, x3, y3]) {
    [x1, y1, x2, y2, x3, y3] = [x1, y1, x2, y2, x3, y3].map(Number);

    distanceComparison(x1,y1,x2,y2,x3,y3);

    function distanceComparison(x1,y1,x2,y2,x3,y3) {
        let firstDis = pitagorTherorem(x1,y1,x2,y2,x3,y3)[0];
        let secondDis = pitagorTherorem(x1,y1,x2,y2,x3,y3)[1];
        let thirdDis = pitagorTherorem(x1,y1,x2,y2,x3,y3)[2];

        if(firstDis <= thirdDis && thirdDis >= secondDis ){
            let totalDis = firstDis + secondDis;
            console.log('1->2->3: ' + totalDis);
        }else if(firstDis <= secondDis && thirdDis <= secondDis){
            let totalDis = thirdDis + firstDis;
            console.log('2->1->3: ' + totalDis);
        }else {
            let totalDis = secondDis + thirdDis;
            console.log('1->3->2: ' + totalDis);
        }
    }

    function pitagorTherorem(x1,y1,x2,y2,x3,y3) {
        let deltaX = x2 - x1;
        let deltaY = y2 - y1;
        let deltaX2 = x3 - x2;
        let deltaY2 = y3 - y2;
        let deltaX3 = x3 - x1;
        let deltaY3 = x3 - y1;
        let distance = Math.sqrt(deltaX * deltaX + deltaY * deltaY);
        let distance2 = Math.sqrt(deltaX2 * deltaX2 + deltaY2 * deltaY2);
        let distance3 = Math.sqrt(deltaX3 * deltaX3 + deltaY3 * deltaY3);
        return [distance, distance2, distance3];
    }
}
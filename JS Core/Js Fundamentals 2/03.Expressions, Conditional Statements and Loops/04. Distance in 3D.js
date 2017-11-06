function solve([x1,y1,z1,x2,y2,z2]) {
    [x1,y1,x1,x2,y2,z2] = [x1,y1,x1,x2,y2,z2].map(Number);
    let xyz = Math.abs(x1-x2)*Math.abs((x1-x2)) + Math.abs(y1-y2)*Math.abs(y1-y2) + Math.abs(z1-z2)*Math.abs(z1-z2)
    let distance = Math.sqrt(xyz) ;
    console.log(distance);
}
solve([1, 1, 0, 5, 4, 0]);
solve([3.5, 0, 1, 0, 2, -1]);
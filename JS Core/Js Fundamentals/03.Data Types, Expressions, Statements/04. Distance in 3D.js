function solve([x1, y1, z1, x2, y2, z2]) {
    [x1, y1, z1, x2, y2, z2] =[x1, y1, z1, x2, y2, z2].map(Number);
    let deltaX = Math.abs(x2 - x1);
    let deltaY = Math.abs(y2 - y1);
    let deltaZ = Math.abs(z2 - z1);
    let distanceWithPitagor = Math.sqrt(deltaX*deltaX + deltaY*deltaY+deltaZ*deltaZ);
    console.log(distanceWithPitagor);
}
solve(['1', '1', '0', '5', '4', '0']);
solve(['3.5', '0', '1', '0', '2', '-1']);
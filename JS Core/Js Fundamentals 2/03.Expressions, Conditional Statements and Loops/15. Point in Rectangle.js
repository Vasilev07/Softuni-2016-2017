function solve([x,y,xMin,xMax,yMin,yMax]) {
    if((x >= xMin && x <= xMax) && (y <= yMax && y >= yMin)){
        return "inside";
    }else {
        return "outside";
    }
}
console.log(solve([8, -1, 2, 12, -3, 3]));;
console.log(solve([12.5, -1, 2, 12, -3, 3]));;
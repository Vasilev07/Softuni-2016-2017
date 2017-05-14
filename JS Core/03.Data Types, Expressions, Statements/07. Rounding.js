function solve([number, rounding]) {
    [number, rounding] = [number, rounding].map(Number);
    let num = parseFloat(number);
    if(rounding >15){
        rounding = 15;
    }
    let total = (num * 1).toFixed(rounding);

    console.log(total.replace(/0+$/, ""))
}
solve(['3.1415926535897932384626433832795', '2'])
solve(['10.5', '3'])
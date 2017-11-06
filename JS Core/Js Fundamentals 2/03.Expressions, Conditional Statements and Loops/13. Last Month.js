function solve([day,month,year]) {
    var d = new Date(year, month - 1, 0);
    console.log(d.getDate());
}
solve([17, 3, 2002]);
solve([13, 12, 2004]);
function solve([day, month, year]) {
    [day, month, year] = [day, month, year].map(Number);
    let date = new Date(year, month-1, 0);
    let days = date.getDate();
    console.log(days);
}
solve(['17','3','2002']);
solve(['13','12','2004']);
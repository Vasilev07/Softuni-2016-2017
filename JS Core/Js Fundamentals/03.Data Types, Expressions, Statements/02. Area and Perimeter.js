function solve(width, height) {

    let area = width * height;
    let perimeter = 2*width + 2* height;
    console.log(Math.round(area * 100) / 100);
    console.log(Math.round(perimeter*100)/100);
}
solve(['2', '2'])
solve(['1', '3'])
solve(['2.5', '3.14'])
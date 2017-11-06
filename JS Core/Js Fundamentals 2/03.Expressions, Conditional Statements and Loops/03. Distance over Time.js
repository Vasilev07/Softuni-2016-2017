function solve([v1,v2,t]) {
    [v1,v2,t] = [v1,v2,t].map(Number);

    console.log(Math.abs(((v1*0.277778) * t) - ((v2*0.277778) * t)));
}
solve([0, 60, 3600]);
solve([11, 10, 120]);
solve([5, -5, 40]);
function solve([a,b,c]) {
    [a,b,c] = [a,b,c].map(Number);
    let discriminant = (b*b) - (4*a*c);
    let x1 = 0;
    let x2 = 0;
    if(discriminant > 0){
        x1 = (-b + Math.sqrt(discriminant))/(2*a);
        x2 = (-b - Math.sqrt(discriminant))/(2*a);
        console.log(Math.min(x1,x2));
        console.log(Math.max(x1,x2));
    }else if(discriminant == 0){
        x1 = (-b)/(2*a);
        console.log(x1);
    }
    else {
        console.log("No");
    }
}
solve(['6','11','-35']);
solve(['1','-12','36']);
solve(['5','2','1']);
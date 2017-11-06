function solve(speed, road) {
    //motorway 130km/h
    //interstate 90km/h
    //city 50km/h
    //residential 20km/h
    //if it is within the limit print nothing
    //up to 20km/h + -- print -- speeding
    //up to 40km/h + -- print -- excessive speeding
    //up to 40km/h ++ -- print -- reckless driving
    if(speed - speedLimit(zone) > 0 && speed - speedLimit(zone) <=20){
        console.log('speeding');
    }else if(speed - speedLimit(zone) >= 20 && speed - speedLimit(zone) <=40){
        console.log('excessive speeding');
    }else if(speed - speedLimit(zone) <= 0){
        console.log("");
    }else {
        console.log('reckless driving');
    }

function speedLimit() {
    switch (road){
        case "residential":
            return 20;
        case "city":
            return 50;
        case "interstate":
            return 90;
        case "motorway":
            return 130;
    }
}

}
solve([40, city]);
solve([21, residential]);
solve([120, interstate]);
solve([200, motorway]);
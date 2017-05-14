function solve([speed, zone]) {
    [speed] = [speed].map(Number);

    if(speed - speedLimit(zone) > 0 && speed - speedLimit(zone) <=20){
        console.log('speeding');
    }else if(speed - speedLimit(zone) >= 20 && speed - speedLimit(zone) <= 40){
        console.log('excessive speeding');

    } else if(speed - speedLimit(zone) <= 0){
        console.log("")

    }else {
        console.log('reckless driving');
    }

    function speedLimit(zone) {
        switch (zone){
            case 'motorway':
                return 130;
                break;
            case 'interstate':
                return 90;
                break;
            case 'city':
                return 50;
                break;
            case 'residential':
                return 20;
                break;
            default:
                return;
                break;
        }
    }
}
solve(['40', 'city']);
solve(['21', 'residential']);
solve(['120', 'interstate']);
solve(['200', 'motorway']);
function solve([movie, days]) {
    let price = 0;
    let film = movie.toLowerCase();
    let day = days.toLowerCase();
    day.toLowerCase();
    switch (film){
        case 'the godfather':
            switch (day){
                case 'monday':
                price = 12;
                break;
                case 'tuesday':
                    price = 10;
                    break;
                case 'wednesday':
                price = 15;
                break;
                case 'thursday':
                    price = 12.5;
                    break;
                case 'friday':
                    price = 15;
                    break;
                case 'saturday':
                    price = 25;
                    break;
                case 'sunday':
                    price = 30;
                    break;
                default:
                    console.log("error");
            }
            break;
        case 'schindler\'s list':
            switch (day){
                case 'monday':
                    price = 8.5;
                    break;
                case 'tuesday':
                    price = 8.5;
                    break;
                case 'wednesday':
                    price = 8.5;
                    break;
                case 'thursday':
                    price = 8.5;
                    break;
                case 'friday':
                    price = 8.5;
                    break;
                case 'saturday':
                    price = 15;
                    break;
                case 'sunday':
                    price = 15;
                    break
                default:
                    console.log("error");
            }
            break;
        case 'casablanca':
            switch (day){
                case 'monday':
                    price = 8;
                    break;
                case 'tuesday':
                    price = 8;
                    break;
                case 'wednesday':
                    price = 8;
                    break;
                case 'thursday':
                    price = 8;
                    break;
                case 'friday':
                  price = 8;
                  break;
                case 'saturday':
                    price = 10;
                    break;
                case 'sunday':
                    price = 10;
                    break;
                default:
                    console.log("error");
            }
            break;
        case 'the wizard of oz':
            switch (day){
                case 'monday':
                    price = 10;
                    break;
                case 'tuesday':
                    price = 10;
                    break;
                case 'wednesday':
                    price = 10;
                    break;
                case 'thursday':
                    price = 10;
                    break;
                case 'friday':
                    price = 10;
                    break;
                case 'saturday':
                    price = 15;
                    break;
                case 'sunday':
                    price = 15;
                    break;
                default:
                    console.log("error");
            }
            break;
        default:
            console.log("error");
    }
    console.log(price);
}
solve(['The Godfather', 'Monday']);
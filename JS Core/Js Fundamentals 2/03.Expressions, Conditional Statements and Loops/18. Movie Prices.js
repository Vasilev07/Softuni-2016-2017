function solve([movieName, day]) {
    day.toLowerCase();
    movieName.toLowerCase();

    let movie = movieName.toLowerCase();
    let days = day.toLowerCase();
    let price = 1;
    switch(days){
        case "monday":
            if(movie == "the godfather"){
                price *= 12;
            }else if(movie == "schindler's list"){
                price *= 8.50;
            }else if(movie == "casablanca"){
                price *= 8;
            }else if(movie == "the wizard of oz"){
                price *= 10;
            }else {
                price = "error";
            }
            break;
        case "tuesday":
            if(movie == "the godfather"){
                price *= 10;
            }else if(movie == "schindler's list"){
                price *= 8.50;
            }else if(movie == "casablanca"){
                price *= 8;
            }else if(movie == "the wizard of oz"){
                price *= 10;
            }else {
                price = "error";
            }
            break;
        case "wednesday":
            if(movie == "the godfather"){
                price *= 15;
            }else if(movie == "schindler's list"){
                price *= 8.50;
            }else if(movie == "casablanca"){
                price *= 8;
            }else if(movie == "the wizard of oz"){
                price *= 10;
            }else {
                price = "error";
            }
            break;
        case "thursday":
            if(movie == "the godfather"){
                price *= 12.50;
            }else if(movie == "schindler's list"){
                price *= 8.50;
            }else if(movie == "casablanca"){
                price *= 8;
            }else if(movie == "the wizard of oz"){
                price *= 10;
            }else {
                price = "error";
            }
            break;
        case "friday":
            if(movie == "the godfather"){
                price *= 15;
            }else if(movie == "schindler's list"){
                price *= 8.50;
            }else if(movie == "casablanca"){
                price *= 8;
            }else if(movie == "the wizard of oz"){
                price *= 10;
            }else {
                price = "error";
            }
            break;
        case "saturday":
            if(movie == "the godfather"){
                price *= 25;
            }else if(movie == "schindler's list"){
                price *= 15;
            }else if(movie == "casablanca"){
                price *= 10;
            }else if(movie == "the wizard of oz"){
                price *= 15;
            }else {
                price = "error";
            }
            break;
        case "sunday":
            if(movie == "the godfather"){
                price *= 30;
            }else if(movie == "schindler's list"){
                price *= 15;
            }else if(movie == "casablanca"){
                price *= 10;
            }else if(movie == "the wizard of oz"){
                price *= 15;
            }else {
                price =  "error";
            }
            break;
        default:
            price = "error";
            break;
    }
    console.log(price);

}
solve(["The Godfather", "Friday"]);
solve(["casablanca", "sunday"]);
solve(["Schindler's LIST", "monday"]);
solve(["SoftUni", "Nineday"]);
function solve(day) {
    let dayAsNumber = function daysOfWeek(day) {
        switch (day) {
            case "Monday":
                return 1;
            case "Tuesday":
                return 2;
            case "Wednesday":
                return 3;
            case "Thursday":
                return 4;
            case "Friday":
                return 5;
            case "Sunday":
                return 7;
            case "Saturday":
                return 6;
            default:
                return "error";
        }
    }
    console.log(dayAsNumber(day));
}
solve('Monday');
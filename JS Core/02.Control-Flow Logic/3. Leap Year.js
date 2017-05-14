function solve([year]) {
    [year] = [year].map(Number);
    return (year % 4 == 0 && year % 100 != 0 ) || (year % 400 == 0) ? "yes":"no";
}
solve(["1999"]);//no
solve(["2000"]);//yes
solve(["1900"]);//no
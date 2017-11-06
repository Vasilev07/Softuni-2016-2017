function employeeData(input) {
    let pattern = /^([A-Z][a-z]+) - (\d+) - ([A-Za-z0-9- ]+)$/;
    for (let obj of input) {
        let match = pattern.exec(input);
        if(match){
            console.log(`Name: ${match[1]}\n` + `Position: ${match[1]}\n` + `Salary: ${match[2]}`)
        }
    }
}
employeeData()
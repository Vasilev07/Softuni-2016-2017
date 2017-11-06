function evenPositionElement(input) {
    let arr = [];
    for (let obj in input) {
        if(obj % 2 == 0) {
            arr.push(input[obj] + " ")
        }
    }
    let result = "";
    for (let obj of arr) {
        result += obj;
    }
    console.log(result)
}
evenPositionElement(['20', '30', '40']);
evenPositionElement(['5', '10']);
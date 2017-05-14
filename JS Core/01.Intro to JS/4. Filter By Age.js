function solve([minAge, firstName, firstAge, secondName, secondAge]) {
    [minAge, firstAge, secondAge] = [minAge, firstAge, secondAge].map(Number);
    let firstUser = {name: firstName, age: firstAge};
    let secondUser = {name: secondName, age: secondAge};
    if(firstAge >= minAge){
        console.log(firstUser)
    }
    if(secondAge >= minAge){
        console.log(secondUser)
    }
}
solve(['12', 'Ivan', '15', 'Asen', '9'])
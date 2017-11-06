function filterByAge([minAge, name1, age1, name2, age2]) {
    let obj = { };
    [minAge, age1, age2] = [minAge, age1, age2].map(Number);
    if(age1 >= minAge){
        obj.name = name1;
        obj.age = age1;
    }
    if(age2 >= minAge){
        obj.name = name2;
        obj.age = age2;
    }
    console.log(obj);
}


filterByAge(['12', 'Ivan', '15', 'Asen', '9']);
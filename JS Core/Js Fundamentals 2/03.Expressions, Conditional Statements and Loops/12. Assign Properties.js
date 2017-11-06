function solve([property,value,property2,value2,property3,value3]) {
   var obj = new Object();
   let propertyHolder = [property,property2,property3];

    obj[propertyHolder[0]] = value;
    obj[propertyHolder[1]] = value2;
    obj[propertyHolder[2]] = value3;
    console.log(obj);
}
solve(['name', 'Pesho', 'age', '23', 'gender', 'male'])
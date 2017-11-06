function company(carInfo) {
    let carCatalogue = new Map();
    for (let info of carInfo) {
        let [car, model, quantity] = info.split(' | ');
        quantity = Number(quantity);
        if(!carCatalogue.has(car)){
            carCatalogue.set(car, new Map());
        }
        let currentCar = carCatalogue.get(car).get(model);
        if(currentCar){
            quantity = quantity + currentCar
        }
        carCatalogue.get(car).set(model, quantity)
    }

    for (let [cars, infoMap] of carCatalogue) {
        console.log(cars);
        for (let [model, quantity] of infoMap) {
            console.log(`###${model} -> ${quantity}`)
        }
    }
}
company([
    'Audi | Q7 | 1000',
    'Audi | Q6 | 100',
    'BMW | X5 | 1000',
    'BMW | X6 | 100',
    'Citroen | C4 | 123',
    'Volga | GAZ-24 | 1000000',
    'Lada | Niva | 1000000',
    'Lada | Jigula | 1000000',
    'Citroen | C4 | 22',
    'Citroen | C5 | 10'
]);
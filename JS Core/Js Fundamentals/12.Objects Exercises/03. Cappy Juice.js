function cappyJuice(input) {
    let juiceHolder = new Map();
    let bottles = new Map();
    for (let line of input) {
        let [juice, quantity] = line.split(' => ');
        if(!juiceHolder.has(juice)){
            juiceHolder.set(juice, 0);
        }
            juiceHolder.set(juice, juiceHolder.get(juice) + Number(quantity));
        if(juiceHolder.get(juice) > 1000){
            let bottlesCount = Math.floor(juiceHolder.get(juice)/1000);
            bottles.set(juice, bottlesCount)
        }
    }
    for (let [key, value] of bottles) {
        console.log(`${key} => ${value}`);
    }
}
cappyJuice([
    'Orange => 2000',
    'Peach => 1432',
    'Banana => 450',
    'Peach => 600',
    'Strawberry => 549'

]);
console.log('-'.repeat(20))
cappyJuice([
    'Kiwi => 234',
    'Pear => 2345',
    'Watermelon => 3456',
    'Kiwi => 4567',
    'Pear => 5678',
    'Watermelon => 6789'
]);
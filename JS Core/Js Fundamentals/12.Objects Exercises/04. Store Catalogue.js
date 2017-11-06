function catalogue(input) {
    let productsFirstLetter = new Map();

    for (let obj of input) {
        let [product, price] = obj.split(' : ');
        let productsLetter = product[0];
        if(!productsFirstLetter.has(productsLetter)){
            productsFirstLetter.set(productsLetter, new Map());
        }
        let productMap = productsFirstLetter.get(productsLetter);
        productMap.set(product, price)
    }
    let sortedKeys = [...productsFirstLetter.entries()]
        .sort(sorting);
    for (let [initial, productMap] of sortedKeys) {
        console.log(initial);
        let sortedProduct = [...productMap.entries()]
            .sort(sorting);
        for (let [name, price] of sortedProduct) {
            console.log(`  ${name}: ${price}`)
        }
    }
    function sorting(a, b) {
        return a[0].localeCompare(b[0]);
    }

}
catalogue([
    'Appricot : 20.4',
    'Fridge : 1500',
    'TV : 1499',
    'Deodorant : 10',
    'Boiler : 300',
    'Apple : 1.25',
    'Anti-Bug Spray : 15',
    'T-Shirt : 10'

]);
console.log('-'.repeat(30));
catalogue([
    'Banana : 2',
    'Rubic\'s Cube : 5',
    'Raspberry P : 4999',
    'Rolex : 100000',
    'Rollon : 10',
    'Rali Car : 2000000',
    'Pesho : 0.000001',
    'Barrel : 10'
]);
function lowestPricesInCityes(townInfo) {
    let products = new Map();
    for (let obj of townInfo) {
        let [town, product, price] = obj.split(' | ');
        if(!products.has(product)){
            products.set(product, new Map());
        }else {
            product.set(town, Number(price));
        }
    }
    for (let [key, value] of products) {
        let lowestPrice = ([...value].reduce(function (a,b) {
            if(a[1]<b[1]){
                return a;
            }else if(a[1] > b[1]){
                return b;
            }
            return a;
        }));

    }


}
lowestPricesInCityes([
    'Sample Town | Sample Product | 1000',
    'Sample Town | Orange | 2',
    'Sample Town | Peach | 1',
    'Sofia | Orange | 3',
    'Sofia | Peach | 2',
    'New York | Sample Product | 1000.1',
    'New York | Burger | 10'
]);


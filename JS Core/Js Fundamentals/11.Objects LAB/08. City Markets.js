function cityMarkets(input) {
    let townObj = new Map();
    for (let obj of input) {
        let [town, product, sales] = obj.split(' -> ');
        sales = sales.split(' : ')
            .reduce((a,b) => a*b);
        fillMap(town, product, sales);
    }
    for (let [town, products] of townObj) {
        console.log(`Town - ${town}`);
        for (let [products, sales] of products) {
            console.log(`$$$${products} : ${sales}`)
        }
    }



    function fillMap(town, product, sales) {
        if(!townObj.has(town)){
            town.set(town, new Map())
        }

        if(!townObj.get(town).has(product)){
            town.get(town).set(product, 0);
        }
        let lastSale = townObj.get(town).get(product);
        townObj.get(town).set(product, lastSale + sales);
    }
}
cityMarkets(['Sofia -> Laptops HP -> 200 : 2000',
',Sofia -> Raspberry -> 200000 : 1500',
'Sofia -> Audi Q7 -> 200 : 100000',
'Montana -> Portokals -> 200000 : 1',
'Montana -> Qgodas -> 20000 : 0.2',
'Montana -> Chereshas -> 1000 : 0.3'])
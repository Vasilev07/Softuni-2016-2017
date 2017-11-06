function heroicInventory(input) {
    let result = [];

    input = input.map(e => e.split(' / ')
        .filter(e => e != ''))

    for (let info of input) {
        let currentName = info[0];
        let currentLevel = Number(info[1]);
        let items = [];
        for (let i = 2; i < info.length; i++) {
            let currentItem = info[i].split(', ');
            items.push(currentItem);
        }

        let currentInventory = {
            name:currentName,
            level:currentLevel,
            items:items
        }

        result.push(currentInventory)
    }
    console.log(JSON.stringify(result))
}

heroicInventory([
    'Isacc / 25 / Apple, GravityGun',
    'Derek / 12 / BarrelVest, Destructi',
    'Hes / 1 / Desolator, Sentinel, Ant',
])
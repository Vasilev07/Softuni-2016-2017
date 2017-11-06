function restaurantBill(input) {
    let products = [];
    let totalSum = 0;
    for (let i = 0; i < input.length; i++) {
        if(i % 2 == 0){
            products.push(input[i]);
        }else {
            totalSum += Number(input[i]);
        }

    }
    console.log(`You purchased ${products.join(', ')} for a total sum of ${totalSum}`);
}
restaurantBill(['Beer Zagorka', '2.65', 'Tripe soup', '7.80','Lasagna', '5.69']);
restaurantBill(['Cola', '1.35', 'Pancakes', '2.88']);
function captureNumbers(text) {
    let result = [];
    result.push(text.split(/\D/).filter(x => x != ""));
    let str = "";
    for (let obj of result) {
        str = obj + " ";
    }
    console.log(str)
}
captureNumbers('Lets g\'o11!!!11!', 'Okey!1!')

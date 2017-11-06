function thePyramidOfKingJoser(baseWidth, increment) {
    [baseWidth, increment] = [baseWidth, increment].map(Number);
    let totalSumOfStones = 0;
    let totalSumOfMarbel = 0;
    let totalSumOfLapis = 0;
    let count = 1;
    let gold = 0;
    while (baseWidth >= 2){
        if(baseWidth-2 === 0){

            break;
        }
        let stonesRequiered = ((baseWidth-2)*(baseWidth-2))*increment;
        totalSumOfStones += stonesRequiered;
        if(baseWidth)
            if(count % 5 !== 0) {
                let marbelRequired = ((baseWidth * 4) - 4) * increment;
                totalSumOfMarbel+=marbelRequired;
            }else {
                let lapisRequired = ((baseWidth * 4) - 4) * increment;
                totalSumOfLapis += lapisRequired;
            }
        baseWidth-=2;
        count++;
    }
    gold += baseWidth*baseWidth*increment
    console.log(`Stone required: ${Math.ceil(totalSumOfStones)}`);
    console.log(`Marble required: ${Math.ceil(totalSumOfMarbel)}`);
    console.log(`Lapis Lazuli required: ${Math.ceil(totalSumOfLapis)}`);
    console.log(`Gold required: ${Math.ceil(gold)}`);
    console.log(`Final pyramid height: ${Math.floor(count*increment)}`);


}
//thePyramidOfKingJoser('11','1');
//thePyramidOfKingJoser('11','0.75');
//thePyramidOfKingJoser('12','1');
thePyramidOfKingJoser('23','0.5');
function extractIncSequence(input) {
    input = input.filter(x=>x!='').map(Number);

    let seq = [];
    let biggest = input[0];
    seq.push(biggest);
    for (let i = 1; i <= input.length; i++) {
        let nextElement = input[i];
        if(biggest < nextElement) {
            seq.push(nextElement);
            biggest = nextElement;
        }
    }
    console.log(seq.join('\n'))
}
//extractIncSequence(['1','3','8','4','10','12','3','2','24']);
//extractIncSequence(['10','2','3','4']);
//extractIncSequence(['20','3','2','15','6','1']);
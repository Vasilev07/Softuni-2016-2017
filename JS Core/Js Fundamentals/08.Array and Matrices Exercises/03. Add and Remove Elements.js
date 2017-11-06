function addRemoveElements(input) {
    input = input.filter(x=>x!='');
    let result = [];
    for (let i = 0; i < input.length; i++) {

        let command = input[i];
        let value = 1;

        if(command == "add"){
            result.push(value);
        }
        if(command == "remove"){
            result.splice(value,1);
        }
    }
    for (let obj of result) {
        console.log(obj)
    }
}
addRemoveElements(['add','add','remove','add'])
//addRemoveElements(['add 3','add 5','remove 2','remove 0','add 7'])

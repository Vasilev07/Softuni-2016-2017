function solve(args) {
    let array = [];
    array[0] = 1;

    for (let i = 1; i < args.length; i++) {

        if(args[i] == "add"){
            addElements(array,i);
        }else {
            removeElement(array);
        }

    }
    for (let obj of array) {
        console.log(obj);
    }
    function addElements(array,i) {
        ++i;
        array.push(i);
    }
    function removeElement(array) {
        if(array.length > 0){
            array.pop()
        }else {
            console.log("Empty");
        }
    }
}
solve(["add","add","add","add"]);
solve(["add","add","remove","add","add"]);
solve(["remove","remove","remove"]);
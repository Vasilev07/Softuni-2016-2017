/**
 * Created by Georgi Vasilev on 3/26/2017.
 */
function solve(args) {
    let dict = [];
    let key;
    let value;

    for(let i = 0; i < args.length-1; i++){

            let current = args[i].split(' ');
            key = current[0];
            value = current[1];
            dict[key]=value;
    }
    let lastElement = args[args.length-1];
    if(dict[lastElement] == undefined){
        console.log('None')
    }else{
        console.log(dict[lastElement]);
    }
}
solve([ 'key value', 'key eulav', 'test tset', 'key' ]);

/**
 * Created by Georgi Vasilev on 3/26/2017.
 */
function solve(args) {
    let current;
    let name;
    let age;
    let grade;
    for(let i = 0; i < args.length-1; i++){
         current = args[i].split(' -> ');
         name = current[0];
         age = current[1];
         grade = current[2];    
    }
    let student = {};
    student.name = name;
    student.age = age;
    student.grade = grade;

    console.log(student.name);

}
solve()
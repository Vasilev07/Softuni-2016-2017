function soleve(args) {
    let first = args[0];
    let second = args[1];
    let third = args[2];
    let fourth = args[3];
    let fifth = args[4];
    let sixth = args[5];

 let obj = {};
  obj[first] = second;
  obj[third] = fourth;
  obj[fifth] = sixth;

 console.log(obj)
}
soleve(['name', 'Pesho', 'age', '23', 'gender', 'male']);
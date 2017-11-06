function solve([n]) {
   [n] = [n].map(Number);
   for(let i = 1; i <= n; i++){
        console.log('*'.repeat(i));
    }
    for(let i = n-1; i >= 1; i--){
        console.log('*'.repeat(i));
    }
}
solve(['1']);
solve(['2']);
solve(['5']);
const girlsPowerSum=(x)=>x/2+3;

const girlsPower=(girlsPowerSum, arr)=>arr.map(girlsPowerSum);

let arr=[1,2,3];
console.log(`Old array= ${arr}; New array= ${girlsPower(girlsPowerSum, arr)}`);
const numbers=[1,2,3,4,5];
const reducer=(previousValue,currentValue)=>previousValue+currentValue;
console.log(numbers.reduce(reducer,15));


/*
const fruits=["Banana","Banana","Apple","Orange","Orange","Orange"];

const occurences=fruits.reduce((acc, currentFruit)=>{
    return {...acc, [currentFruit]: (acc[currentFruit]||0)+1}},
    {}
);

console.log(occurences);

*/

// getting max-length || min-length value from an array using reduce
const fruits = [ 'Banana', 'Dragon', 'Apple', 'Orange', 'Pear', 'Elderberry']

const max=fruits.reduce((acc,fruit)=>{
if(acc===null||fruit.length>acc)
return fruit.length;
else
return acc;
}, null);

console.log(max); // 10

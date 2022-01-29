/*const numbers=[1,2,3,4,5];

const multiply2=numbers.map(num=>{
    return num*2;
});

console.log(multiply2);

const multiply3=item=>item*3;

const numberArr=numbers.map(multiply3);
console.log(numberArr);
*/


/*
const pato="PATATES";
let map= Array.prototype.map
const newPato = map.call(pato,letter=(x)=>{
    return x.charAt(0);
});

//console.log(newPato);

///magiccc momentsss    
console.log([...pato]); //kolay yol
*/

const myUsers=[
    {name:'Asli', likes:'patates'},
    {name:'Aizat',likes:'Cikolata'},
    {name:'Nurcan', likes:'Et'},
    {name:'Duygu',likes:'Helva'}
]

const usersByLikes=myUsers.map(item=>{
    const temp={};
    temp[item.name]=item.likes;
    temp.age=item.likes.length*10;
    return temp;
});

console.log(usersByLikes);
const oldArr=[1,2];
const newArr=[...oldArr,3,4];
console.log(newArr);


//with function
function sortArg(...arg){
    return arg.sort();
}

const filter=(...args)=>{
    return args.filter(eleman=>eleman>1);
}

console.log(sortArg(1,5,8,3,9,4));
console.log(filter(1,2,4,5,3));

//böyle atama yaptığımızda atanmış olan değeri değiştirirken atadığımız değeri de değiştiriyoruz
const person = {
    name:'Asli',
    age:21
};
//böyle yapılan atamalar sonrasında yeni değer atarsak sıkıntı olmaz
const newPerson1={
    ...person
};

newPerson=person;
person.name='Aizat';
console.log(newPerson);
console.log(newPerson1);

let fruits =['Apple','Orange','Banana'];
let newFruit=[...fruits,'Cherry'];
console.log(newFruit);

let fruit=['apple','orange','banana'];

const getFruit=(f1,f2,f3)=>{
    console.log(`Fruits:${f1},${f2} and ${f3}`);
};

getFruit(...fruit);



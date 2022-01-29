/*onst name="su";
const CopyName="Aizat";
name="MK";
console.log(name);
console.log(CopyName);
*/


/*let arr=[1,2,3,4];
let copyArr=arr;
console.log(copyArr);
arr=[1,2,3,4,5];
arr.push(6);
console.log(copyArr);*/

/*let name="Merve";
//Hi, Merve
console.log(`Hi, ${name}!`);
*/

/*let str=`This is a
m
u
l
t
i
l
i
n
e
string`;
console.log(str);*/

/*let name="Suna";
//Hello
//Suna
console.log(`Hello
${name}`);*/


/*
//*****array destructuring ******
const foo=['one','two','three'];
const [bir,iki,uc]=foo;
console.log(bir);
console.log(iki);
console.log(uc);
console.log(dort); // is not defined
*/

/*
const object1={val1:42, val2:true};
const{val1, val2}=object1;
console.log(val1);
*/


/*
// ** Arrow functions***
const print=()=>{
    console.log("hey");
}
print();

const printMessage=(message)=>{
    console.log(message);
}

printMessage("It is my message");

// ** Default parameter ***

const areaOfTheCircle=(r,p=3.14)=>{
    return (r*r)*p;
}
console.log("Area of the circle is: "+areaOfTheCircle(2));
*/

/*
//in one line example above
const areaOfTheCircle=(r, p=3.14)=>(r*r)*p;
console.log("Area of the circle is: "+areaOfTheCircle(2));

*/


/*var person={
    name:"Alex",
    actions:["reading","dancing","running"],
    printActions: function()
    {
        var _this=this;
        this.actions.forEach(function(action)
        {
            console.log(_this.name+" likes "+action);
        });
    }
};
person.printActions();*/


/*
function foo()
{
    var bar="bar";
    let baz="baz";
    const qux="qux";
    console.log(bar);
    console.log(baz);
    console.log(qux);

}
foo();
const foo2="foo";
console.log(bar);// is not defined
let baz="baziko";
console.log(baz);
*/

/*
// ** iflerin icinde tanimlanan var her yerde tanimlanmis oluyor
if(true)
{
    var bar="bar";
    let baz="baz";
    const qux="qux"; 
}
console.log(bar);
console.log(baz); // referenceError
console.log(qux); // referenceError
*/

// ****HOW TO ASSIGN CONST VALUE****


/*
let list=[4,5,6,7];

//indexes
for(i in list)
{
    console.log(i);
}

//values
for(i of list)
{
    console.log(i);
}

*/

var {x=2, y=4, z=6}={x:10};
console.log(x);
console.log(y);
console.log(z);
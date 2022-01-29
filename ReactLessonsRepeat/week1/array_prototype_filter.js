/*
const fruits=['apple','banana','pineapple','pear'];

const fruits6=fruits.filter(fruit=>{
    return (fruit.length>6);
})
console.log(fruits6);
*/

//filter funny character
const creatures = [
    {name: "SpongeBob", personality: "Funny"},
    {name: "Mater", personality: "Funny"},
    {name: "Gargamel", personality: "Antagonistic"},
    {name: "Voldemort", habitat: "Unkind"}
];

const funnyyCharacter=creatures.filter(ch=>{
    return ch.personality=="Funny";
});

console.log(funnyyCharacter);
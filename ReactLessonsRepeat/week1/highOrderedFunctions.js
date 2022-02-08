// step 

let plus =number=>number+2;
const func=plus;
console.log(func(2));

// step 2 
// callback
const isEven=number=>number%2==0;


// parametre olarak function alıp, sonrasında function dönebilen fonksiyonlara high ordered function diyoruz
let message=(evenFunc,n)=>{
    const isNumEven=evenFunc(n);
    console.log(`sayı ${n} çift midir? : ${isNumEven};`);
}
message(isEven,5);


//yazdığımız kod tek satır olacak ve 3 tane sayıyı toplayacak func
// map-filter-resuce ya da array func hazır method kullanamayız

const sum= (x)=>(y)=>(z)=> console.log(x+y+z);
sum(1)(2)(3);
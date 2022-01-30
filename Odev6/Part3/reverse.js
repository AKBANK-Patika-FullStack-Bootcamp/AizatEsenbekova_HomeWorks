//1
function reverseString(str) {
    var splitString = str.split("");
    var reverseArray = splitString.reverse();
    var joinArray = reverseArray.join(""); 
    return joinArray;
}

//2
function reverseStringSecond(str) {
    return str.split("").reverse().join("");
}

//3
function reverseStringThird(str) {
    var tempString = "";
    for (var i = str.length - 1; i >= 0; i--) {
        tempString += str[i];
    }
    return tempString;
}
//4
function reverseStringFourth(str) {
    return (str === '') ? '' : reverseString(str.substr(1)) + str.charAt(0);
}



//1
console.log('\n');
console.log("First Way ");
console.log(reverseString("Aizat"));

//2
console.log('\n');
console.log("Second Way ");
console.log(reverseStringSecond('Aizat'));

//3
console.log('\n');
console.log("Third Way ");
console.log(reverseStringThird('Aizat'));

//4
console.log('\n');
console.log("Fourth Way ");
console.log(reverseStringFourth('Aizat'));
console.log("HI");


const myDog = {
    dogName: "Sharko",
    age: 3,
    breed: "dzukela",
    color: "brown",
    isHungry: false,
    isHappy: true
};

let dogsName = myDog.dogName;
let dogsAge = myDog.age;
let dogsColor = myDog.color;
// gets a bit boring...

// destructuring of an object

let { dogName, age, color, isHappy } = myDog;
console.log(dogName);
console.log(age);

// destructuring of an array
let rgbValues = [255, 125, 0];

let redValue = rgbValues[0];
let greenValue = rgbValues[1];
// this gets boring too

let [ red, green, blue ] = rgbValues;
console.log(red);

// spread syntax

function sumNumbers(num1, num2, num3) {
    return num1 + num2 + num3;
}

let result1 = sumNumbers(1, 5, 10);

let numArray = [2, 4, 6];

let result12 = sumNumbers(numArray[0], numArray[1], numArray[2]);

let result2Updated = sumNumbers(...numArray);
console.log(result2Updated);

console.log("NUM ARRAY", numArray);
// copy of an array
// newNumArray will be only a pointer to the same numArray!!!!
// let newNumArray = numArray;

// good way
let newNumArrayBetter = [...numArray];
console.log("COPY OF NUM ARRAY", newNumArrayBetter);

newNumArrayBetter.push(10);
console.log("NUM ARRAY", numArray);
console.log("COPY OF NUM ARRAY", newNumArrayBetter);

// array & object are reference types
console.log("Salamlar")

function isDivisibleBy3And7(n) {
    return n % 3 === 0 && n % 7 === 0;
}

function factorial(n) {
    if (n < 0) {
        return "Musbet eded daxil edin";
    }
    if (n === 0 || n === 1) {
        return 1;
    }
    let result = 1;
    for (let i = 2; i <= n; i++) {
        result *= i;
    }
    return result;
}

function sumOfSquaresOfEvenNumbers(arr) {
    let sum = 0;
    for (let i = 0; i < arr.length; i++) {
        if (typeof arr[i] === 'number' && arr[i] % 2 === 0) {
            sum += arr[i] * arr[i];
        }
    }
    return sum;
}

function login(mail, password) {
    if (mail === "emil@code.edu.az" && password === "12345") {
        console.log("Girish olundu");
    } else {
        console.log("Mail ve yaxud password sehvdir");
    }
}

function sumOfOddNumbers(arr) {
    let sum = 0;
    for (let i = 0; i < arr.length; i++) {
        if (typeof arr[i] === 'number' && arr[i] % 2 !== 0) {
            sum += arr[i];
        }
    }
    return sum;
}

function countOfEvenNumbers(arr) {
    let count = 0;
    for (let i = 0; i < arr.length; i++) {
        if (typeof arr[i] === 'number' && arr[i] % 2 === 0) {
            count++;
        }
    }
    return count;
}


console.log("\n=== Test Nəticələri ===");


console.log("\n1) 21 ədədi 3-ə və 7-ə bölünür? " + isDivisibleBy3And7(21));
console.log("   42 ədədi 3-ə və 7-ə bölünür? " + isDivisibleBy3And7(42));
console.log("   10 ədədi 3-ə və 7-ə bölünür? " + isDivisibleBy3And7(10));

console.log("\n2) 5-in faktorialı: " + factorial(5));
console.log("   7-in faktorialı: " + factorial(7));
console.log("   0-in faktorialı: " + factorial(0));


let arr1 = [1, 2, 3, 4, 5, 6];
console.log("\n3) Array: [1, 2, 3, 4, 5, 6]");
console.log("   Cüt ədədlərin kvadratlarının cəmi: " + sumOfSquaresOfEvenNumbers(arr1));


console.log("\n4) Login testi:");
login("emil@code.edu.az", "12345");
login("test@test.com", "12345");
login("emil@code.edu.az", "wrong");


let arr2 = [1, 2, 3, 4, 5, 6, 7, 8, 9];
console.log("\n5) Array: [1, 2, 3, 4, 5, 6, 7, 8, 9]");
console.log("   Tək ədədlərin cəmi: " + sumOfOddNumbers(arr2));


let arr3 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
console.log("\n6) Array: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]");
console.log("   Cüt ədədlərin sayı: " + countOfEvenNumbers(arr3));
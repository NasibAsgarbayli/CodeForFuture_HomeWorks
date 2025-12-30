// Task 1 == Verillmis ededin 3 e ve 7 ye bolunub bolunmediyini tapan funksiya yazin
function checkDivisibility(number) {
  if (number % 3 === 0 && number % 7 === 0) {
    return true;
  } else {
    return false;
  }
}
console.log(checkDivisibility(21));
console.log(checkDivisibility(10));
/////////////////////////////////////////////////////////////////////////////////////

// Task 2 == Functiona musbet bir eded gelir, hemin funksiya gelen ededin faktorialini hesablayib geri qaytarmalidir.
function calculateFactorial(num) {
  if (num < 0) {
    return "Number has to be greater than 0.";
  }
  let factorial = 1;
  for (let i = 1; i <= num; i++) {
    factorial *= i;
  }
  return factorial;
}
console.log(calculateFactorial(5));
console.log(calculateFactorial(0));
console.log(calculateFactorial(-3));
/////////////////////////////////////////////////////////////////////////////////////

// Task 3 == Her hansisa number elementleri olan arayin icindeki cut ededlerin kvadratlarinin cemini hesablayan bir function yazin.
function sumOfSquaresOfEvenNumbers(arr) {
  let sum = 0;
  for (let i = 0; i < arr.length; i++) {
    if (arr[i] % 2 === 0) {
      sum += arr[i] * arr[i];
    }
  }
  return sum;
}
console.log(sumOfSquaresOfEvenNumbers([1, 2, 3, 4, 5]));
console.log(sumOfSquaresOfEvenNumbers([10, 15, 20, 25]));
console.log(sumOfSquaresOfEvenNumbers([7, 9, 11]));
/////////////////////////////////////////////////////////////////////////////////////

// Task 4 == Funtiona-a  mail ve password gelir. Mail beraberdirse emil@code.edu.az -a ve password beraberdirse 12345 -e, ekranda "Girish olundu" yazilsin, eks halda "Mail ve yaxud password sehvdir" yazilsin.
function Login(email, password) {
  const correctEmail = "emil@code.edu.az";
  const correctPassword = "12345";
  if (email === correctEmail && password === correctPassword) {
    return "Successfully logged in";
  } else {
    return "Email or password is incorrect";
  }
}
console.log(login("emil@code.edu.az", "12345"));
console.log(login("wrong@gmail.com", "12345"));
/////////////////////////////////////////////////////////////////////////////////////

// Task 5 == Functiona ededlerden ibaret array gelir, function hemin arraydaki tek ededlerin cemini qaytarmalidir.
function sumOfOddNumbers(arr) {
  let sum = 0;
  for (let i = 0; i < arr.length; i++) {
    if (arr[i] % 2 !== 0) {
      sum += arr[i];
    }
  }
  return sum;
}
console.log(sumOfOddNumbers([1, 2, 3, 4, 5]));
console.log(sumOfOddNumbers([10, 15, 20, 25]));
console.log(sumOfOddNumbers([2, 4, 6]));
/////////////////////////////////////////////////////////////////////////////////////

// Task 6 == Functiona ededlerden ibaret array gelir, function hemin arraydaki cut ededlerin sayini qaytarmalidir.
function countEvenNumbers(arr) {
  let count = 0;
  for (let i = 0; i < arr.length; i++) {
    if (arr[i] % 2 === 0) {
      count++;
    }
  }
  return count;
}
console.log(countEvenNumbers([1, 2, 3, 4, 5]));
console.log(countEvenNumbers([10, 15, 20, 25]));
console.log(countEvenNumbers([1, 3, 5]));
/////////////////////////////////////////////////////////////////////////////////////

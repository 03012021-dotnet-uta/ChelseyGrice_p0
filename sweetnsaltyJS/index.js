let startIndex = 1;
let endIndex = 1000;
let sweetWord = "sweet";
let saltydWord = "salty";
let sweetnsaltyWord = "saltNSalty";
let firstNum = 3;
let secondNum = 5;
let firstWordCounter = 0;
let secondWordCounter = 0;
let thirdWordCounter = 0;

let sns = "";

// loop to check each number
for(let i = startIndex; i <= endIndex; i++)
{

    if ((i % firstNum == 0) && (i % secondNum == 0))
    {
         sns += (thirdWord + " ");
         thirdWordCounter++;
    }
    else if (i % firstNum == 0)
    {
        sns += (firstWord + " ");
        firstWordCounter++;//incriment by one everytime sweet is called
    }

    else if (i % secondNum == 0)
    {
        sns += (secondWord + " ");
        secondWordCounter++;
    }else
    {
        sns += (i + " ");
    }

    if(i % 10 == 0)
    {
        console.log(sns);
        sns = "";
    }
    
}

console.log("The number of times " + firstWord + " occurs: " + firstWordCounter);
console.log("The number of times " + secondWord + " occurs: " + secondWordCounter);
console.log("The number of times " + thirdWord + " occurs: " + thirdWordCounter);
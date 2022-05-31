function sameNumbers(number) {
    let input = String(number);
    let isSame = true;
    let firstDigit = input[0];
    let digitSum = 0;
    
    for (let i = 0; i < input.length; i++) {
        let currentDigit = Number(input[i]);
        digitSum += currentDigit;
        if (currentDigit != firstDigit) {
            isSame = false;
        }
        
    }
    console.log(isSame);
    console.log(digitSum);
}

sameNumbers(2222222);
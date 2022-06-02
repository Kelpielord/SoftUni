function sortNumbers(arr) {
    arr.sort((a, b) => a - b);
    let result = [];
    const middleOfArray = Math.floor(arr.length / 2);

    for (let i = 0; i < middleOfArray; i++) {
        result.push(arr[i]);
        result.push(arr[arr.length - 1 - i]);
    }

    if (arr.length % 2 > 0) {
        result.push(arr[middleOfArray]);
    }

    return result;
}

sortNumbers([1, 54, -3, 6, 12]);
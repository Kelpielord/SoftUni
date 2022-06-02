function solve(arr) {
    let result = [];
    let currentBiggestNum = 0;

    for (const num of arr) {
        if (num >= currentBiggestNum) {
            currentBiggestNum = num;
            result.push(num);
        }
    }

    return result;
}

solve([1, 3, 8, 4, 10, 12, 3, 2, 24]);
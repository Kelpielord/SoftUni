function printEveryNElement(arr, num) {
    const result = [];

    for (let i = 0; i < arr.length; i+= num) {
        result.push(arr[i]);
    }
    return result;
}

printEveryNElement(['5','20','31','4','20'], 2);
printEveryNElement(['dsa', 'asd', 'test', 'tset'], 2);
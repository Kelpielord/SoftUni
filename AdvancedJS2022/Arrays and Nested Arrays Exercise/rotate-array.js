function rotateArray(arr, num) {

    for (let i = 0; i < num; i++) {
        let lastNum = arr.pop();
        arr.unshift(lastNum);
    }
    console.log(arr.join(' '));
}

rotateArray(['Banana', 'Orange', 'Coconut', 'Apple'], 15);
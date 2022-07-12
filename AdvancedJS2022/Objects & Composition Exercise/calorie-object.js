function getFoodAndCal(arr) {
    let object = {};

    for (let i = 0; i < arr.length; i++) {
        if (i % 2 == 0) {
            object[arr[i]] = Number(arr[i + 1]);
        }
    }

    return object;
}

console.log(getFoodAndCal(['Yoghurt', '48', 'Rise', '138','Apple', '52']));
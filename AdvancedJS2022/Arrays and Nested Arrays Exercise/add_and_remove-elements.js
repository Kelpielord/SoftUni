function addAndRemove(arr) {
    let numToAdd = 1;
    const result = [];

    for (let i = 0; i < arr.length; i++) {
        if (arr[i] == 'add') {
            result.push(numToAdd)
        }
        else if (arr[i] == 'remove') {
            result.pop();
        }
        numToAdd++;
    }
    if (result.length == 0) {
        console.log('Empty');
    }

    console.log(result.join('\n'));
}

addAndRemove(['remove', 'remove', 'remove']);
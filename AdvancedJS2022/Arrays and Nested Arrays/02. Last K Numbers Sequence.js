function solve(input) {
    let firstElement = input.shift();
    let lastElement = input.pop();

    let result = Number(firstElement) + Number(lastElement);

    console.log(result);
}

solve(['20', '30', '40']);
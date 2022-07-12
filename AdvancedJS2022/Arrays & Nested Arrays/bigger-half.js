function solve(input) {
    input.sort((a, b) => a - b);
    
    const result = [];

    for (let i = Math.floor(input.length / 2); i < input.length; i++) {
        result.push(input[i]);
    }

    return result;
}
function solve(arr) {
    const result = arr.filter((x, i) => i % 2 != 0).map(x => x * 2).reverse();
    console.log(result.join(' '));  
}

solve([10, 15, 20, 25]);
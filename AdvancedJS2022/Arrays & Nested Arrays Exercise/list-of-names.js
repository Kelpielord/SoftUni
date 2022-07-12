function sortNames(arr) {
    const result = arr.sort((a, b) => a.localeCompare(b));

    for (let i = 0; i < arr.length; i++) {
        console.log(`${i + 1}.${result[i]}`);
    }
}

sortNames(["John", "Bob", "Christina", "Ema"]);
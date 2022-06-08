function getTownAndPopulation(arr) {
    const result = {};

    for (const towns of arr) {
        const tokens = towns.split('<->');
        const town = tokens[0];
        if (result[town] == undefined) {
            result[town] = Number(tokens[1]);
        }
        else {
            result[town] += Number(tokens[1]);
        }
    }

    for (const town in result) {
        console.log(`${town}: ${result[town]}`);
    }
}

getTownAndPopulation(['Sofia <-> 1200000', 'Montana <-> 20000', 'New York <-> 10000000', 'Washington <-> 2345000', 'Las Vegas <-> 1000000']);
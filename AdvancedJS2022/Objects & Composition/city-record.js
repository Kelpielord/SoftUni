function setCity(name, population, treasury) {
    const result = {
        name: name,
        population: population,
        treasury: treasury
    };

    return result;
}

console.log(setCity('Tortuga', 7000, 15000));
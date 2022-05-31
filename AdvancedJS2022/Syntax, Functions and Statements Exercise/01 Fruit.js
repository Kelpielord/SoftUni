function fruit(fruitName, weightInGrams, pricePerKilo) {
    let kilograms = weightInGrams / 1000;
    let price = pricePerKilo * kilograms;

    console.log(`I need $${price.toFixed(2)} to buy ${kilograms.toFixed(2)} kilograms ${fruitName}.`)
}

fruit('orange', 2500, 1.80);
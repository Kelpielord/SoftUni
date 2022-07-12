function calcLowestPriceInCity(arr) {
    const cheapestPrices = {};

    for (const item of arr) {
        let [townName, productName, productPrice] = item.split(' | ');
        productPrice = Number(productPrice);

        if (!cheapestPrices[productName] || cheapestPrices[productName].productPrice > productPrice) {
            cheapestPrices[productName] = {
                productPrice: productPrice,
                townName: townName
            };
        }
    }

    for (const prop in cheapestPrices) {
        console.log(`${prop} -> ${cheapestPrices[prop].productPrice} (${cheapestPrices[prop].townName})`);
    }
}

calcLowestPriceInCity(['Sample Town | Sample Product | 1000',

'Sample Town | Orange | 2',

'Sample Town | Peach | 1',

'Sofia | Orange | 3',

'Sofia | Peach | 2',

'New York | Sample Product | 1000.1',

'New York | Burger | 10'])
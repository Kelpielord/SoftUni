function circle(radius) {
    if (typeof radius == 'number') {
        let result = radius ** 2 * Math.PI;

        console.log(result.toFixed(2));
    }
    else {
        console.log(`We can not calculate the circle area, because we receive a ${typeof radius}.`)
    }
}

circle(5);
circle('name');
circle([1,2,3]);

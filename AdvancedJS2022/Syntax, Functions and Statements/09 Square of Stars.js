function rectangle (rectangleSize = 5) {

    for (let i = 1; i < rectangleSize - 1; i++) {

        console.log('*')

        for (let j = 1; j < rectangleSize / 2; j++) {
            console.log('*')
        }
    }
}

rectangle(5);
function getCarRequierments(car) {
    if (car.wheelsize % 2 == 0) {
        Math.floor(car.wheelsize -= 1);
    }

    let carEngines = {
        smallEngine: { power: 90, volume: 1800 },
        normalEngine: { power: 120, volume: 2400 },
        monsterEngine: { power: 200, volume: 3500 },
    }

    let engine = 0;
    if (car.power <= 90) {
        engine = carEngines.smallEngine;
    }
    else if (car.power <= 120) {
        engine = carEngines.normalEngine;
    }
    else if (car.power <= 200) {
        engine = carEngines.monsterEngine;
    }
    
    let newCarSpecifics = {
        model: car.model,
        engine: engine,
        carriage: {type: car.carriage, color: car.color},
        wheels: new Array(4).fill(car.wheelsize)
    };
    
    return newCarSpecifics;
}

console.log(getCarRequierments({ model: 'VW Golf II',

power: 90,

color: 'blue',

carriage: 'hatchback',

wheelsize: 14 }));
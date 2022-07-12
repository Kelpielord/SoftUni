function convertTownsToJson(arr) {
    let towns = {};

    for (const item of arr) {
        let [town, latitude, longitude] = item.split(' | ');
        latitude = Number(latitude);
        longitude = Number(longitude);

        towns = {
            Town: town,
            Latitude: latitude,
            Longitude: longitude
        };
    }

    console.log(JSON.stringify(towns));
}

convertTownsToJson(['| Town | Latitude | Longitude |',

'| Sofia | 42.696552 | 23.32601 |',

'| Beijing | 39.913818 | 116.363625 |']);
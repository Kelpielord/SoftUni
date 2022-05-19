function dayOfWeek (day) {
    let target = day.toLowerCase();  

    switch (target) {
        case 'monday':
            console.log(1);
            break;
        case 'tuesday':
            console.log(2);
            break;
        case 'wednesday':
            console.log(3);
            break;
        case 'thursday':
            console.log(4);
            break;
        case 'friday':
            console.log(5);
            break;
        case 'saturday':
            console.log(6);
            break;
        case 'sunday':
            console.log(7);
            break;
        default:
            console.log('error')
            break;
    }
}

console.log(dayOfWeek('monday'));

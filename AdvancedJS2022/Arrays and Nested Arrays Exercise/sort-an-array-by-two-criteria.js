function sortArray(arr) {
    arr.sort(sortByLengthAndAlphabeticalOrder);
    console.log(arr.join('\n'));

    function sortByLengthAndAlphabeticalOrder(a, b) {
        if (a.length > b.length) {
            return 1;
        }
        if (b.length > a.length) {
            return -1;
        }
        
        return a.toUpperCase().localeCompare(b.toUpperCase());
    }
}



sortArray(['alpha', 'beta', 'gamma']);
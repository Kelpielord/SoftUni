function magicMatrix(matrix) {
    let magicNumber = 0;
    
    for (let i = 0; i < matrix.length; i++) {
        let rowArr = matrix[i];
        let currentRowSum = 0;
        let currentColSum = 0;

        for (let j = 0; j < rowArr.length; j++) {
            currentRowSum += matrix[i][j];
            currentColSum += matrix[j][i];
        }

        if (i == 0) {
            magicNumber = currentRowSum;
        }
        else if (currentRowSum != magicNumber){
            console.log('false');
            return;
        }
        else if (currentColSum != magicNumber){
            console.log('false');
            return;
        }
    }

    console.log('true');
}

magicMatrix([[11, 32, 45], [21, 0, 1]]);

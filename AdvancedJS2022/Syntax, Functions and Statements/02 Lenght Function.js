function strLenCalc (a, b, c) {
    let totalLen = a.length + b.length + c.length;
    let lenAvrg = Math.floor(totalLen / 3);

    console.log(totalLen);
    console.log(lenAvrg);
}

strLenCalc('chocolate', 'ice cream', 'cake');
strLenCalc('pasta', '5', '22.3');
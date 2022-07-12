function solve() {
  const input = document.getElementById('text').value.toLowerCase().trim().split(' ');
  const currentCase = document.getElementById('naming-convention').value;

  String.prototype.replaceAt = function (index, replacement) {
    return this.substring(0, index) + replacement + this.substring(index + replacement.length);
  }

  if (currentCase == 'Camel Case') {
    let concatenatedString = input[0];

    for (let i = 1; i < input.length; i++) {
      const word = input[i];
      concatenatedString += word.replaceAt(0, word[0].toUpperCase());
    }
    document.getElementById('result').textContent = concatenatedString;
  }
  else if (currentCase == 'Pascal Case') {
    let concatenatedString = '';

    for (let i = 0; i < input.length; i++) {
      const word = input[i];
      concatenatedString += word.replaceAt(0, word[0].toUpperCase());
    }
    document.getElementById('result').textContent = concatenatedString;
  }
  else {
    document.getElementById('result').textContent = "Error!";
  }
}
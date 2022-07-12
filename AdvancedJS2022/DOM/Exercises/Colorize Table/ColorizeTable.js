function colorize() {
  const rows = document.getElementsByTagName('tr');

  for (let row = 1; row < rows.length; row+=2) {
    rows[row].style.backgroundColor = 'teal';
  }
}
function sumTable() {
  const rows = Array.from(document.querySelectorAll('tr')).slice(1, -1);
  let sum = 0;

  for (let row of rows) {
    let result = Number(row.lastElementChild.textContent);
    sum += result;
    document.getElementById('sum').textContent = sum;
  }
}
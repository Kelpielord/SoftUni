function extractText() {
    const items = Array.from(document.querySelectorAll('li'));
    
    const result = items.map(x => x.textContent).join('\n');

    document.getElementById('result').value = result;
}
function editElement(element, textToReplace, textToReplaceWith) {
    const text = element.textContent;
    const pattern = new RegExp(textToReplace, 'g');
    const result = text.replace(pattern, textToReplaceWith);
    element.textContent = result;
}
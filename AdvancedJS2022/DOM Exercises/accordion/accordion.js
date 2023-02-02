let isExpanded = false;
function toggle() {
  const changeButtonText = document.getElementsByClassName('button')[0];
  const expandTextField = document.getElementById('extra');

  if (isExpanded) {
    changeButtonText.textContent = 'More';
    expandTextField.style.display = 'none';
  }
  else {
    changeButtonText.textContent = 'Less';
    expandTextField.style.display = 'block';
  }

  isExpanded = !isExpanded;
}
function generateButton() {
    const button = document.createElement('button');
    button.textContent = 'Szia';
    button.style.background = randomColor();
    button.onclick = function() {
      toggleButtonLocation(button);
    };
  
    document.getElementById('pirosDiv').appendChild(button);
  }
  
  function randomColor() {
    const r = Math.floor(Math.random() * 256);
    const g = Math.floor(Math.random() * 256);
    const b = Math.floor(Math.random() * 256);
    return `rgb(${r},${g},${b})`;
  }
  
  function toggleButtonLocation(button) {
    const pirosDiv = document.getElementById('pirosDiv');
    const kekDiv = document.getElementById('kekDiv');
    if (button.parentNode === pirosDiv) {
      kekDiv.appendChild(button);
    } else {
      pirosDiv.appendChild(button);
    }
  }
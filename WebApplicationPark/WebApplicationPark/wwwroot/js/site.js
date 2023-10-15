const logo = document.getElementById('logo');
logo.addEventListener('mouseover', () => {
    logo.style.transform = 'rotate(360deg)';
});

logo.addEventListener('mouseout', () => {
    logo.style.transform = 'rotate(0deg)';
});
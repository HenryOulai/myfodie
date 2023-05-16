// Add to cart functionality
const addToCartButtons = document.querySelectorAll('.add-to-cart');
const shoppingCart = document.getElementById('shopping-cart');
const shoppingCartItems = {};

addToCartButtons.forEach(button => {
    button.addEventListener('click', () => {
        const recipeId = button.getAttribute('data-recipe-id');
        if (shoppingCartItems[recipeId]) {
            shoppingCartItems[recipeId]++;
        } else {
            shoppingCartItems[recipeId] = 1;
        }
        updateShoppingCart();
    });
});

function updateShoppingCart() {
    shoppingCart.innerHTML = '';
    for (const recipeId in shoppingCartItems) {
        const item = document.createElement('div');
        item.textContent = `Recipe ${recipeId}: ${shoppingCartItems[recipeId]}`;
        shoppingCart.appendChild(item);
    }
    shoppingCart.style.display = 'block';
}

// Slideshow functionality
var slideIndex = 1;
showDivs(slideIndex);

function plusDivs(n) {
    showDivs(slideIndex += n);
}

function showDivs(n) {
    var i;
    var x = document.getElementsByClassName("mySlides");
    if (n > x.length) { slideIndex = 1 }
    if (n < 1) { slideIndex = x.length }
    for (i = 0; i < x.length; i++) {
        x[i].style.display = "none";
    }
    x[slideIndex - 1].style.display = "block";
}

let cartItemCount = 0;

function addToCart() {
    cartItemCount++;
    document.getElementById('cart-number').innerText = cartItemCount;
}

let addToCartButtons = document.getElementsByClassName('add-to-cart');

for (let i = 0; i < addToCartButtons.length; i++) {
    addToCartButtons[i].addEventListener('click', addToCart);
}

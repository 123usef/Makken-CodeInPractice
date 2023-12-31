const id = localStorage.getItem("id");
let products = JSON.parse(localStorage.getItem("products"));
let product = products.filter((item)=>{
return item.id == id
})
product = product[0]
console.log(product)
document.write(
  `
    <div id="product">
      <div class="image">
        <img src=${product.image}> 
      </div>
      <div class="title">
        <h2>${product.title}</h2>
         <p id="desc">${product.description}</p>
      </div>
      <div class="details">
        <p id="price">price: ${product.price}</p>
        <p id="category">category: ${product.category}</p>
        <p id="rate">rate: ${product.rating.rate}</p>
      </div>
  </div>
`
);



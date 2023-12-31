async function getData() {
  let data = await fetch("https://fakestoreapi.com/products");
  data = await data.json();
  localStorage.setItem("products", JSON.stringify(data));
  display()
}
getData()
async function display() {
  let prosucts =  JSON.parse(localStorage.getItem("products"));
  let productsData = ""
  prosucts.forEach((product) => {
       productsData += `   
        <div class="item" onclick='saveId(${product.id})'>
          <a href="./details.html">
            <h3>${product.title}</h3>
            <img src=${product.image}>  
          </a>
        </div>
        `;
  });
  document.getElementById("products").innerHTML = productsData;
}

function saveId (id){
    localStorage.setItem("id", id);
}


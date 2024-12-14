import { useEffect, useState } from "react";
import { Product } from "../models/product";

function App() {
  const [products, setProducts] = useState<Product[]>([]);

  useEffect(() => {
    fetch("http://localhost:5000/api/products")
      .then((response) => response.json())
      .then((data) => setProducts(data));
  }, []);

  function addProduct() {
    setProducts((prevState) => [
      ...prevState,
      {
        id: prevState.length + 101,
        name: "Product " + (prevState.length + 1),
        price: prevState.length * 100 + 100,
        brand: "some brand",
        description: "desc",
        pictureUrl: "http://picsum.photos/200",
      },
    ]);
  }

  return (
    <div>
      <h1>Re-Store</h1>
      <ul>
        {products.map((item) => (
          <li key={item.id}>
            {item.name} - {item.price}
          </li>
        ))}
      </ul>
      <button onClick={addProduct}>Add Product</button>
    </div>
  );
}

export default App;

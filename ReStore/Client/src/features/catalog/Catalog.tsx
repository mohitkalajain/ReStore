import axios from "axios";
import { Product } from "../../app/models/product";
import ProductList from "./ProductList";
import { useState, useEffect } from "react";

export default function Catalog() {
  const [products, setProducts] = useState<Product[]>([]);
  const [loading, setLoading] = useState(true);
  useEffect(() => {

    axios
      .get(`http://localhost:5000/api/products/get`)
      .then((response) => {
        if (response.data.flag && response.data.statusCode === 200) {
          console.log("Product Details:", response.data.response);
          setProducts(response.data.response);
        } else {
          console.error("Error:", response.data.message);
        }
      })
      .catch((error) => console.log(error))
      .finally(() => setLoading(false));

  }, []);

  if (loading) return <h3>Loading . . .</h3>;
  
  return (
    <>
      <ProductList products={products}></ProductList>
    </>
  );
}

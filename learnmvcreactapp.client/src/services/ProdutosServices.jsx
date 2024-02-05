import axios from "axios"
class ProdutosServices {
  #ApiBaseUrl = "https://localhost:7236/api/Produtos/"


  async get(){
    try {
      const response = await axios.get(this.#ApiBaseUrl)
      return response;
    } catch (error) {
      console.error(error)
    }
  }

}

export default ProdutosServices;
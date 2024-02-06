import axios from "axios"
import Cookies from "universal-cookie";
class ProdutosServices {
  #ApiBaseUrl = "https://localhost:7236/api/Produtos/"


  async get(){
    try {
      const cookies = new Cookies();
      const token = cookies.get('token');
      if(token != null){
        const response = await axios.get(this.#ApiBaseUrl,{
          headers: {
            Authorization: `Bearer ${token}` // Adiciona o token como um cabeçalho de autorização Bearer
          }
        })
        return response;
      }
      
    } catch (error) {
      console.error(error)
    }
  }

}

export default ProdutosServices;
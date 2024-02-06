import Cookies from "universal-cookie";
import axios from "axios";
class UsuarioServices{
  #ApiBaseUrl = "https://localhost:7236/api/Usuarios/"


  async get(){
    try {
      const cookies = new Cookies();
      const token = cookies.get('token');
      const id = cookies.get('id');
      if(token != null && id != null){
        const urlIdUsuario = this.#ApiBaseUrl + id;
        const response = await axios.get(urlIdUsuario,{
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
export default UsuarioServices;
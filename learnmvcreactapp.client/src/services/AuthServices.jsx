import axios from "axios"
import Cookies from "universal-cookie";
class AuthServices{
  #ApiBaseUrl = "https://localhost:7236/api/Usuarios/login"
  #cookies = new Cookies();
  async LogOut(){
    this.#cookies.set('id',null)
    this.#cookies.set('nome', null)
    this.#cookies.set('token',null)
  }
  async Login(Nome){
    try {
      const response = await axios.post(this.#ApiBaseUrl,{
        nome:Nome
      })
      const dataUsuarioLogin = response.data;
      this.#cookies.set('id', dataUsuarioLogin.usuario.id)
      this.#cookies.set('nome', dataUsuarioLogin.usuario.nome)
      this.#cookies.set('token', dataUsuarioLogin.token)
      return dataUsuarioLogin.usuario;
    } catch (error) {
      console.error(error)
    }
  }
}

export default AuthServices;
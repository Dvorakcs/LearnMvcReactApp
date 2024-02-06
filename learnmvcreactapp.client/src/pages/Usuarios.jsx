import React from "react";
import UsuarioServices from '../services/UsuarioServices'
import AuthServices from '../services/AuthServices'
import { Navigate } from 'react-router-dom';
class Usuarios extends React.Component{
  constructor(){
    super()
    this.state = {
      usuario : null,
      isLogin:false
    };
  }
  async componentDidMount(){
    const usuarioServices = new UsuarioServices();
    const userData = await usuarioServices.get();
   if(userData){
    const user = userData.data;
    this.setState({usuario:user})
   }else{
    this.setState({isLogin:true})
   }
  }
  async Logout(){
    const authServices = new AuthServices();
    await authServices.LogOut();
    this.setState({isLogin:true})
  }
 
  render(){
    return (
      <div>
        {
        this.state.isLogin == true ? <Navigate to="/Auth" replace={true} /> 
        :
        this.state.usuario && <h3>Nome Usuario: {this.state.usuario.nome}</h3>
        }
       <button onClick={() => this.Logout()}>Sair</button>
      </div>
    )
  }
}
export default Usuarios;
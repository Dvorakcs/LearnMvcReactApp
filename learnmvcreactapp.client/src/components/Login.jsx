import React from "react";
import Style from "./Login.module.css"
import AuthServices from "../services/AuthServices"
import { Navigate } from 'react-router-dom';
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import {faUser} from "@fortawesome/free-solid-svg-icons";
class Login extends React.Component{
constructor(){
  super()
  this.state = {
    InputLoginValue : '',
    usuario: null
  };
  } 
 async Login(){
    const auth = new AuthServices();
    const nomeLogin = this.state.InputLoginValue;
    const user = await auth.Login(nomeLogin)
    this.setState({usuario:user})
  }
  SetValueInput = (event) => {
    this.setState({InputLoginValue:event.target.value})
  }
  render(){
    return(
      this.state.usuario != null ?( <Navigate to="/produtos" replace={true} />):
      <div className={Style.containerLogin}>
        <FontAwesomeIcon className={Style.icon} icon={faUser}></FontAwesomeIcon>
        <input placeholder="Nome Usuario" onChange={(event) => this.SetValueInput(event)}/>
        <button onClick={() => this.Login()}>Login in</button>
      </div>
    )
  }

  
}

export default Login;
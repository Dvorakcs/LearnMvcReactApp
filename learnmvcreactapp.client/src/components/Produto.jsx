import React from "react";
import Styles from "./Produto.module.css"
class Produto extends React.Component{
  render(){
    return (
      <div className={Styles.cardProduto}>
        <img src={this.props.urlImage}/>
        <div className={Styles.cardBody}>
        <hr></hr>
        <h2>{this.props.Nome}</h2>
        <h3>{this.props.Descricao}</h3>
        <button>Comprar R$99,99</button>
       </div>
      </div>
    )
  }
}

export default Produto
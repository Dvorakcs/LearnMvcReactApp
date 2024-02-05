import React from "react";
class Produto extends React.Component{
  render(){
    return (
      <div className="cardProduto">
        <img src={this.props.urlImage}/>
       <div className="cardBody">
        <h1>{this.props.Nome}</h1>
        <h3>{this.props.Descricao}</h3>
        <button >Comprar</button>
       </div>
      </div>
    )
  }
}

export default Produto
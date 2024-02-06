import React from "react";
import Produto from "../components/Produto";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faMagnifyingGlass } from "@fortawesome/free-solid-svg-icons";
import ProdutosServices from "../services/ProdutosServices";
import Style from "./Produtos.module.css"
class Produtos extends React.Component{
 constructor(props){
  super(props)
  this.state = {
    produtosServices: null,
  };
 }

 async componentDidMount() {
  try {
    const produtosServices = new ProdutosServices();
    const produtos = await produtosServices.get();
    if(produtos.data.length > 0) this.setState({ produtosServices: produtos.data });
  } catch (error) {
    console.error('Erro ao obter produtos na página Produtos:', error);
  }
}

  componentDidUpdate() {
    
  }
  render() {
    return (
      <div className={Style.container}>
        
         
        {this.state.produtosServices &&
          <div>
          <input placeholder="Pesquisar Produtos"/>
          <FontAwesomeIcon className={Style.icon} icon={faMagnifyingGlass}/>
         </div>
        }
        <div className={Style.containerProdutos}>
          
        { 
           this.state.produtosServices ==null ? 
           <h1>Carregando Produtos</h1> :
           this.state.produtosServices && this.state.produtosServices.map((produto, index) => {
            
            return (
              <div key={index} className="containerItemProdutos">
                <Produto urlImage={produto.urlImage} Nome={produto.nome} Descricao={produto.descricao} />
              </div>
            );
          })
        }
      </div>
      </div>
    );
  }



}
export default Produtos
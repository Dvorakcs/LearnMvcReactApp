import React from "react";
import Produto from "../components/Produto";
import ProdutosServices from "../services/ProdutosServices";
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
    this.setState({ produtosServices: produtos.data });
    // Você também pode usar o setState diretamente dentro do try.
  } catch (error) {
    console.error('Erro ao obter produtos na página Produtos:', error);
  }
}

// getDerivedStateFromProps é estático e não pode acessar o 'this' da instância da classe
static getDerivedStateFromProps(nextProps, prevState) {
  // Retorna um objeto representando as alterações de estado que você deseja realizar
  return null;
}
  componentDidUpdate() {
    
  }
  render() {
    return (
      <div className="containerProdutos">
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
    );
  }



}
export default Produtos
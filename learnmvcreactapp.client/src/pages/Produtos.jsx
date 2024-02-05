import React from "react";
import Produto from "../components/Produto";
class Produtos extends React.Component{
  ProdutosList = [
    {
      urlImage:"...",
      Nome:"Produto 1",
      Descricao:"Descricao produto 1"
    },
    {
      urlImage:"...",
      Nome:"Produto 2",
      Descricao:"Descricao produto 2"
    },
    {
      urlImage:"...",
      Nome:"Produto 3",
      Descricao:"Descricao produto 3"
    },
    {
      urlImage:"...",
      Nome:"Produto 4",
      Descricao:"Descricao produto 4"
    }
  ]
  ProdutosHtml = []
  render(){
    
    
    return (
     <div className="containerProdutos">
      {
         this.ProdutosList.map((produto,index) => {
          return(<div key={index} className="containerItemProdutos">
          <Produto urlImage={produto.urlImage} Nome={produto.Nome} Descricao={produto.Descricao}/>
          </div>)
         })
      }
     </div>
    )
  }


}
export default Produtos
import React from "react";
import Styles from "./Layout.module.css"
class Layout extends React.Component{
  constructor(props){
    super(props)

  }
  render(){
    return (
        <nav className={Styles.navContainer}>
            <a className={Styles.navText} href="/">Home</a>
            <a className={Styles.navText} href="/Produtos">Produtos</a>
        </nav>

    )
  }
}

export default Layout;
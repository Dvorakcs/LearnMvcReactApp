import React from "react";
import Styles from "./Layout.module.css"
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faBagShopping, faUser, faShop, faHouse} from "@fortawesome/free-solid-svg-icons";
class Layout extends React.Component{
  constructor(props){
    super(props)

  }
  render(){
    return (
        <nav className={Styles.navContainer}>
            <a className={Styles.navText} title="Home" href="/"><FontAwesomeIcon icon={faHouse}></FontAwesomeIcon></a>
            <a className={Styles.navText} title="Produtos" href="/Produtos"><FontAwesomeIcon icon={faShop}></FontAwesomeIcon></a>
            <a className={Styles.navText} title="User" href="/Usuarios"><FontAwesomeIcon icon={faUser}></FontAwesomeIcon></a>
            <a className={Styles.navText} title="Bag" href="/Bag"><FontAwesomeIcon icon={faBagShopping}></FontAwesomeIcon></a>
        </nav>

    )
  }
}

export default Layout;
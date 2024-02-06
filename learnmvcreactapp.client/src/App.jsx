import React from 'react';
import './App.css';
import Produtos from './pages/Produtos';
import Usuarios from './pages/Usuarios';
import { BrowserRouter, Route, Routes } from 'react-router-dom';
import Auth from './pages/Auth';
class App extends React.Component {
    render() {
        return (
        <BrowserRouter>
            <Routes>
                <Route path='/'>
                    <Route path='/produtos' element={<Produtos/>}/>
                    <Route path='/auth' element={<Auth/>}/>
                    <Route path='/usuarios' element={<Usuarios/>}/>
                </Route>
            </Routes>
        </BrowserRouter>
       
        )
    }
}

export default App;
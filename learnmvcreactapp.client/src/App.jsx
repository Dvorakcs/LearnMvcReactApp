import React from 'react';
import './App.css';
import Produtos from './pages/Produtos';
import { BrowserRouter, Route, Routes } from 'react-router-dom';
class App extends React.Component {
    render() {
        return (
        <BrowserRouter>
            <Routes>
                <Route path='/'>
                    <Route path='/produtos' element={<Produtos/>}/>
                </Route>
            </Routes>
        </BrowserRouter>
       
        )
    }
}

export default App;
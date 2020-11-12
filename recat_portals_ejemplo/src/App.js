import logo from "./logo.svg";
import "./App.css";
import React, { Component } from "react";
import Modal from "./Modal";

export default class App extends Component {
  state = {
    actico: false,
  };
  toggle = () => {
    this.setState({
      activo: !this.state.activo,
    });
  };
  render() {
    return (
      <div className="App">
        <h1>Soy App.js</h1>
        <button onClick={this.toggle}>Mostrar modal</button>
        <Modal toggle={this.toggle} activo={this.state.activo}>
          <h2>Soy un texto de modal</h2>
        </Modal>
      </div>
    );
  }
}

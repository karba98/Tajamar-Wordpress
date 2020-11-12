import React, { Component } from "react";
import ReactDOM from "react-dom";

const portal = document.getElementById("portal");
export default class Portal extends Component {
  nuevodiv = document.createElement("div");
  componentDidMount = () => {
    portal.appendChild(this.nuevodiv);
  };
  componentWillUnmount = () => {
    portal.removeChild(this.nuevodiv);
  };
  render() {
    return ReactDOM.createPortal(this.props.children, this.nuevodiv);
  }
}

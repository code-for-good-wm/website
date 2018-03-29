import React, { Component } from 'react';
import { MenuBar } from './MenuBar';

export class Layout extends Component {
  displayName = Layout.name

  render() {
    return (
      <div className="container">
        <MenuBar />
        <section className="main-content">{this.props.children}</section>
      </div>
    );
  }
}

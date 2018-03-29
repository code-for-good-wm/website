import React, { Component } from 'react';
import { Hero } from './Hero';

export class Home extends Component {
  displayName = Home.name

  render() {
    return (
      <div className="home">
          <Hero />
      </div>
    );
  }
}

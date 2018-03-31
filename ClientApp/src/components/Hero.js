import React, { PureComponent } from 'react';
import './hero.css';

export class Hero extends PureComponent {
    displayName = Hero.name

    render() {
        return (
            <section className="hero">
                <div className="hero-overlay">
                    <div className="cta-message">
                        <h3>Proudly giving to those who give!</h3>
                        <button className="cta-button">Get Started</button>
                    </div>
                </div>
            </section>
        );
    }
}
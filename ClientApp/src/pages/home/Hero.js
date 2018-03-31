import React, { PureComponent } from 'react';
import { Button } from 'react-bootstrap';
import './hero.css';

export class Hero extends PureComponent {
    
    render() {
        return (
            <section className="hero">
                <div className="hero-overlay">
                    <div className="cta-message">
                        <h3>Proudly giving to those who give!</h3>
                        <Button bsStyle="primary" bsSize="large">Get Started</Button>
                    </div>
                </div>
            </section>
        );
    }
}
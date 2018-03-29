import React, { PureComponent } from 'react';

export class Logo extends PureComponent {
    displayName = Logo.name

    render() {
        return (
            <div className="logo">
                <img src="/assets/logo.png" alt="Code for Good West Michigan" />
                <h1>Code for Good</h1>
                <h2>West Michigan</h2>
            </div>
        );
    }
}
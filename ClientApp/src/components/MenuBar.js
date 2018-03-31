import React, { Component } from 'react';
import { Logo } from './Logo';
import './menu-bar.css';

export class MenuBar extends Component {
    displayName = MenuBar.name

    render() {
        return (
            <header className="menu-bar">
                <Logo />
                <nav className="menu-toggle">
                    <a href="#">Menu</a>
                </nav>
            </header>
        );
    }
}

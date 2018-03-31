import React, { Component } from 'react';

export class About extends Component {

    render() {
        return (
            <div className="about">
                <h1>About GiveCamp</h1>
                <p>One of dozens of GiveCamps nationwide, Grand Rapids GiveCamp is a weekend-long event in Grand Rapids, Michigan where technology professionals – designers, developers, database administrators, marketers, and web strategists – donate their time to provide free technology solutions for non-profit organizations. GR GiveCamp is a volunteer-run organization, working in partnership with the SoftwareGR, that connects technology professionals with nonprofit organizations.</p>
                <p>Through GR GiveCamp, non-profit organizations with specific technology needs are matched with teams of local technology professionals who volunteer their time over the course of one weekend to develop free technology solutions such as new websites, databases, e-newsletter programs, and social media campaigns.</p>
                <p>Staff and resources at nonprofit organizations are stretched thin. GiveCamp provides technology solutions to support program, outreach, development, and operational objectives for nonprofits who may not otherwise be able to afford them.</p>
                <ul>
                    <li>Does your non-profit need a new website?</li>
                    <li>Time to escape those Excel spreadsheets and get a real donor database?</li>
                    <li>Trying to figure out how to build your social media presence?</li>
                </ul>
            </div>
        );
    }
}

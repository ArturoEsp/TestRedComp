import React from 'react'
import './styles.css'
import SVG_LOGO from '../../assets/logo-redco.svg'

export const Header = () => {
    return (
        <div className="c__header">
            <div className="icon">
                <img src={SVG_LOGO} alt="" />
            </div>
            <div className="title">
                <span>Arturo Espinoza Herrera</span>
            </div>
        </div>
    )
};

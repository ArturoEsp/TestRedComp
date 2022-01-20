import React, { useEffect, useState } from 'react'
import { PopupOptions } from './PopupOptions'
import './styles.css'

export const BoxInformation = (props) => {

    const { options, title, expand } = props


    return (
        <>
            <div className="c__boxInformation">
                <div className="title-box">
                    <span className="title">
                        {title}
                    </span>
                    {options ? <PopupOptions component={options} /> : null}
                </div>
                <div className="content-box sc1">
                    <div>
                        {
                            props.loading ?
                                <div className="wrapper_loading"><div className="loading"></div></div> :
                                props.children
                                
                        }
                    </div>
                </div>
            </div>
        </>
    )
}


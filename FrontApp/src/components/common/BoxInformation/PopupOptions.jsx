import React from 'react'
import { BiDotsHorizontalRounded } from 'react-icons/bi'
import Popup from 'reactjs-popup'

export const PopupOptions = ({ component }) => {
    return (
        <Popup
            trigger={open => (<button className="dots_button"><BiDotsHorizontalRounded /></button>)}
            position="bottom center"
            nested
            className='box-options'
            closeOnDocumentClick >
            { component }
        </Popup>
    )
}

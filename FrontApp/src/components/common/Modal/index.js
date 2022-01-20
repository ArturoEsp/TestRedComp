import React, { useEffect, useState } from 'react'
import Popup from 'reactjs-popup'

import './styles.css'

export const Modal = ({ open, close, content, title, width = 'normal' }) => {

  const [openModal, setOpenModal] = useState(false)

  useEffect(() => {
    if (open) setOpenModal(true)
    else setOpenModal(false)
  }, [open])

  return (
    <Popup modal nested className={`modal__custom`} open={openModal} onClose={close} closeOnDocumentClick={false}>
      {close => (
        <div className={`c__modal ${width}`}>
          <div className="header">
            <div className="title">
              <h2>{title ?? ''}</h2>
            </div>
            <div className="button-close">
              <button className="close" onClick={close}> &times;</button>
            </div>
          </div>
          <div className="content">
            {content}
          </div>
        </div>
      )}
    </Popup>
  )
}
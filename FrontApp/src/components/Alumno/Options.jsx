import React, { useState } from 'react'
import { Modal } from '../common/Modal'
import { FormAsignarCalificaciones } from './FormAsignarCalificaciones'

export const Options = () => {
    const [openModal, setOpenModal] = useState(false)

    const handleOpenModal = () => setOpenModal(!openModal)
    return (
        <> 
            <Modal open={openModal} title='Asignar calificaciones' content={<FormAsignarCalificaciones />} />
            <ul className="list-items">
                <ul>
                    <button onClick={handleOpenModal}>Asignar calificación</button>
                </ul>
            </ul>
        </>
    )
}

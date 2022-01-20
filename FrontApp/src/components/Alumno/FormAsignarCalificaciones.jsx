import React from 'react'
import { Formik, Form, Field, ErrorMessage } from 'formik';
import { useListMaterias } from '../Materia/hooks'
import { useListAlumnos } from './hooks';

export const FormAsignarCalificaciones = () => {

    const [dataMaterias, errorMaterias] = useListMaterias()
    const [dataAlumnos, errorAlumnos] = useListAlumnos()

    const handleSubmit = (values) => {
        console.log(values)
    }

    return (
        <Formik
            initialValues={{ materia: '1', alumno: '1', calificacion: 0 }}
            onSubmit={handleSubmit}
        >
            <Form className="Form">
                <div className="input">
                    <label htmlFor="materia">Materia</label>
                    <Field as="select" name="materia">
                        {
                            dataMaterias.map(e => (<option key={e.id} value={e.id}>{e.nombre}</option>))
                        }
                    </Field>
                </div>
                <div className="input">
                    <label htmlFor="materia">Alumno</label>
                    <Field as="select" name="alumno">
                        {
                            dataAlumnos.map(e => (<option key={e.id} value={e.id}>{e.nombre}</option>))
                        }
                    </Field>
                </div>
                <div className="input">
                    <label htmlFor="calificacion">Calificación</label>
                    <Field name="calificacion" type="text" />
                </div>
                <button type="submit">Aceptar</button>
            </Form>
        </Formik>
    )
}

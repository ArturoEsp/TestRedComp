import { useState, useEffect } from 'react'
import instanceAxios from '../../axios'
import { ROUTES_ALUMNOS } from '../../axios/routes'

export const columns = [
    { Header: 'ID', accessor: e => e.id },
    { Header: 'Nombre', accessor: e => e.nombre },
    { Header: 'Apellido', accessor: e => e.apellido},
    { Header: 'cedula', accessor: e => e.cedula },
    { Header: 'Aula', accessor:  e => e.aula.numero },
]

export const fakeData = [
    { id: 1, nombre: 'Arturo', apellido: 'Espinoza', cedula: '20211321', aula: '201' },
    { id: 2, nombre: 'Jorge', apellido: 'Maldonado', cedula: '20218232', aula: '202' },
    { id: 3, nombre: 'Martín', apellido: 'López', cedula: '202142232', aula: '203' },
    { id: 4, nombre: 'Luisa', apellido: 'Hernadez', cedula: '202153432', aula: '201' }
]


export const useListAlumnos = () => {
    const [dataAlumnos, setDataAlumnos] = useState([])
    const [errorAlumnos, setErrorAlumnos] = useState(false);

    useEffect(() => {
        instanceAxios.get(ROUTES_ALUMNOS.GET_ALUMNOS).then((response) => {
            setDataAlumnos(response.data)
        }).catch((error) => {
            setErrorAlumnos(error)
        });
    }, [])
    
    return [dataAlumnos, errorAlumnos]
}


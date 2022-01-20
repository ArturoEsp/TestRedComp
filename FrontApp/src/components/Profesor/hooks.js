import { useState, useEffect } from 'react'
import instanceAxios from '../../axios'
import { ROUTES_ALUMNOS, ROUTES_PROFESORES } from '../../axios/routes'

export const columns = [
    { Header: 'ID', accessor: e => e.id },
    { Header: 'Nombre', accessor: e => e.nombre },
    { Header: 'Apellido', accessor: e => e.apellido},
    { Header: 'Identificación', accessor: e => e.identificacion },
    { Header: 'Aula', accessor:  e => e.aula.numero },
]



export const useListProfesors = () => {
    const [dataProfesors, setDataProfesors] = useState([])
    const [errorProfesors, setErrorProfesors] = useState(false);

    useEffect(() => {
        instanceAxios.get(ROUTES_PROFESORES.GET_PROFESORES).then((response) => {
            setDataProfesors(response.data)
        }).catch((error) => {
            setErrorProfesors(error)
        });
    }, [])
    
    return [dataProfesors, errorProfesors]
}

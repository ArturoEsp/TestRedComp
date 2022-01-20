import { useState, useEffect } from 'react'
import instanceAxios from '../../axios'
import { ROUTES_MATERIAS } from '../../axios/routes'

export const columns = [
    { Header: 'ID', accessor: e => e.id },
    { Header: 'Nombre', accessor: e => e.nombre },
    { Header: 'Profesor', accessor: e => `${e.profesor.nombre} ${e.profesor.apellido}`},
]



export const useListMaterias = () => {
    const [dataMaterias, setDataMaterias] = useState([])
    const [errorMaterias, setErrorMaterias] = useState(false);

    useEffect(() => {
        instanceAxios.get(ROUTES_MATERIAS.GET_MATERIAS).then((response) => {
            setDataMaterias(response.data)
        }).catch((error) => {
            setErrorMaterias(error)
        });
    }, [])
    
    return [dataMaterias, errorMaterias]
}

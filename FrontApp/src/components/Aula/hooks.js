import { useState, useEffect } from 'react'
import instanceAxios from '../../axios'
import { ROUTES_AULAS } from '../../axios/routes'

export const columns = [
    { Header: 'ID', accessor: e => e.id },
    { Header: 'Número', accessor: e => e.numero },
    { Header: 'Edifico', accessor: e => e.edificio },
]

export const useListAulas = () => {
    const [dataAulas, setDataAulas] = useState([])
    const [errorAulas, setErrroAulas] = useState(false);

    useEffect(() => {
        instanceAxios.get(ROUTES_AULAS.GET_AULAS).then((response) => {
            console.log(response.data)
            setDataAulas(response.data)
        }).catch((error) => {
            setErrroAulas(error)
        });
    }, [])
    
    return [dataAulas, errorAulas]
}

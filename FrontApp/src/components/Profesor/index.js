import React from 'react'
import { columns, useListProfesors } from './hooks'
import { BoxInformation } from '../common/BoxInformation'
import { TableDataBox } from '../common/Table'

export const Profesor = () => {

    const [dataProfesors, errorProfesors] = useListProfesors()
 
    return (
        <BoxInformation title='Lista de Profesores'>
            <TableDataBox columns={columns} data={dataProfesors} loading={false} />
        </BoxInformation>
    )
}

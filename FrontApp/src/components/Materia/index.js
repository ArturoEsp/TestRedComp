import React from 'react'
import { columns, useListMaterias } from './hooks'
import { BoxInformation } from '../common/BoxInformation'
import { TableDataBox } from '../common/Table'

export const Materia = () => {

    const [dataMaterias, errorMaterias] = useListMaterias()
 
    return (
        <BoxInformation title='Lista de Materias'>
            <TableDataBox columns={columns} data={dataMaterias} loading={false} />
        </BoxInformation>
    )
}

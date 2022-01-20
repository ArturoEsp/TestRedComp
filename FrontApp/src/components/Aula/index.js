import React from 'react'
import { columns, useListAulas } from './hooks'
import { BoxInformation } from '../common/BoxInformation'
import { TableDataBox } from '../common/Table'

export const Aula = () => {

    const [dataAulas, errorAulas] = useListAulas()
    console.log(dataAulas)
    return (
        <BoxInformation title='Lista de Aulas'>
            <TableDataBox columns={columns} data={dataAulas} loading={false} />
        </BoxInformation>
    )
}

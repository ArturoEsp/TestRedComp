import React from 'react'
import { fakeData, columns, useListAlumnos } from './hooks'
import { BoxInformation } from '../common/BoxInformation'
import { TableDataBox } from '../common/Table'
import './styles.css'
import { Options } from './Options'

export const Alumno = () => {

    const [dataAlumnos, errorAlumnos] = useListAlumnos()

    return (
        <BoxInformation title='Lista de Alumnos' options={<Options />}>
            <TableDataBox columns={columns} data={dataAlumnos} loading={false} />
        </BoxInformation>
    )
}

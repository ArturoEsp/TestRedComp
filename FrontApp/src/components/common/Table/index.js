import React, { useState, useEffect } from 'react'
import { useTable, useGlobalFilter, useFilters, useSortBy, usePagination } from 'react-table'

import { IoIosArrowDown, IoIosArrowUp } from "react-icons/io"

import { Loading } from './Loading'
import './styles.css'

export const TableDataBox = ({ columns = [], data = [], loading = false }) => {
    const [isLoading, setIsLoading] = useState(false)

    useEffect(() => {
        if (loading) setIsLoading(true)
        else setIsLoading(false)
    }, [loading])

    const { state, getTableProps, getTableBodyProps, headerGroups, prepareRow, rows } = useTable(
        { columns, data }, useGlobalFilter, useFilters, useSortBy)
    return (
        <div className="c__tableDataBox">
            {
                isLoading ? <Loading /> :
                    <table {...getTableProps()} className="table">
                        <thead>
                            {headerGroups.map((headerGroup) => (
                                <tr {...headerGroup.getHeaderGroupProps()}>
                                    {headerGroup.headers.map((column, i) => (
                                        <th key={i} {...column.getHeaderProps(column.getSortByToggleProps())}>
                                            {column.render('Header')}
                                            <span>
                                                {column.isSorted
                                                    ? column.isSortedDesc
                                                        ? <span className="short-icon"> <IoIosArrowDown /></span>
                                                        : <span className="short-icon"> <IoIosArrowUp /></span>
                                                    : ''}
                                            </span>
                                        </th>
                                    ))}

                                </tr>
                            ))}
                        </thead>
                        <tbody {...getTableBodyProps()} className="sc1">
                            {rows.map((row, i) => {
                                prepareRow(row);
                                return (
                                    <tr {...row.getRowProps()} className="data_row">
                                        {row.cells.map((cell, i) => {
                                            return <td key={i} {...cell.getCellProps()} data-label={cell.render("Cell").props.column.Header}>
                                                {cell.render("Cell")}
                                            </td>;
                                        })}
                                    </tr>
                                );
                            })}
                        </tbody>
                    </table>
            }
        </div>
    )
}

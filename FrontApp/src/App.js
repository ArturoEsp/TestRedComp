import React from 'react'
import logo from './logo.svg'
import './index.css'
import './normalize.css'
import { Header } from './components/Header'
import { Alumno } from './components/Alumno'
import { Profesor } from './components/Profesor'
import { Aula } from './components/Aula'
import { Materia } from './components/Materia'
export const App = () => {
  return (
    <>
      <Header />
      <div className="content__app">
          <Alumno />
          <Profesor />
          <Aula />
          <Materia />
      </div>
    </>
  )
};


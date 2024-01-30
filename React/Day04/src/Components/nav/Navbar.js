import React from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { Link } from 'react-router-dom'
import ChangeLang from '../../store/Action/LanguageAction/LanguageAction'
export default function Navbar() {
  const lang   = useSelector((state) =>state.language.lang)
  const dispatch = useDispatch();
  // ChangeLang(){

  // }
  const ChangeLanguage = (payload)=>{
    dispatch(ChangeLang(payload))
  }

  return (
    <>
    <div className='container' >
    <nav className="navbar navbar-expand-lg bg-body-tertiary">
  <div className="container-fluid">
    <Link className="navbar-brand" to="/">Navbar</Link>
    <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
      <span className="navbar-toggler-icon"></span>
    </button>
    <div className="collapse navbar-collapse" id="navbarSupportedContent">
      <ul className="navbar-nav me-auto mb-2 mb-lg-0">
        <li className="nav-item">
          <Link className="nav-link active" aria-current="page" to="/">Home</Link>
        </li>
        <li className="nav-item">
          <Link className="nav-link" to="/listtodo">Todos</Link>
        </li>
        
        <li className="nav-item">
          <Link className="nav-link " to='/Addtodo'>AddTodo</Link>
        </li>
      </ul>

      <button type="button" onClick={lang=="en" ?  ()=>ChangeLanguage("ar") : ()=>ChangeLanguage("en") } class="btn btn-primary position-relative">
  Language
  <span class="position-absolute top-0 start-100 translate-middle badge rounded-pill bg-danger">
    {lang}
    <span class="visually-hidden">unread messages</span>
  </span>
</button>
    </div>
  </div>
</nav>
    
</div>
    </>
  )
}

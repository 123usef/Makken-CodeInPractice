import React, { useEffect, useState } from 'react'
import { Link, useLocation, useNavigate, useParams } from 'react-router-dom'
import NotFound from '../../NotFound/NotFound';
import { useBootstrapBreakpoints } from 'react-bootstrap/esm/ThemeProvider';
import axios from 'axios';

export default function TodoList() {
  const [Users , setUsers] = useState([]); //empty 

  useEffect(()=>{
    axios.get('https://fakestoreapi.com/users',{
      params:{
        limit:5
      }
    })
    .then((res) => setUsers(res.data))
    .catch((err) => console.log(err))

  },[]); // component did Mount 

  return (
    <div>
        <h2>Listing todos </h2>
      <div className='container'> 
      <ul>
      {Users.map((item,idx) =>{
          return ( <Link to={`/detailedTodo/${item.id} `}  > <li> {item.email} </li> </Link> ) 
      })}
      </ul>
      </div>
      
    </div>
  )
}

import React, { useEffect, useState } from 'react'
import { Link, useLocation, useNavigate, useParams } from 'react-router-dom'
import NotFound from '../../NotFound/NotFound';
import { useBootstrapBreakpoints } from 'react-bootstrap/esm/ThemeProvider';
import axios from 'axios';
import { axiosInstance } from '../../../network/AxiosInstance';
import Loader from '../../../Components/Loader/Loader';
import { useDispatch, useSelector } from 'react-redux';
import { isLoader } from '../../../store/Action/ProductAction/ProductAction';

export default function TodoList() {
  const [Users , setUsers] = useState([]); //empty 
  const load = useSelector((state)=> state.count.isloading)  
  const dispatch = useDispatch() ;
  useEffect(()=>{
    axiosInstance.get('/users',{
      params:{
        limit:5
      }
    })
    .then((res) => {
      setUsers(res.data)
      dispatch(isLoader(false))
    })
    .catch((err) => console.log(err))

  },[]); // component did Mount 

  return (
    <div>
        <h2>Listing todos </h2>
       { load ?  <Loader /> :   
      <div className='container'> 
      <ul>
      {Users.map((item,idx) =>{
          return ( <Link to={`/detailedTodo/${item.id} `}  > <li> {item.email} </li> </Link> ) 
      })}
      </ul>
      </div>
      
    }
    </div>
  )
}

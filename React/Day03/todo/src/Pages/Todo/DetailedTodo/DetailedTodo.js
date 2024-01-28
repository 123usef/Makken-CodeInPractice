import React, { useEffect , useState } from 'react'
import { useParams } from 'react-router-dom'
import axios from 'axios';
export default function DetailedTodo() {
    const params = useParams(); // used to access the Parameters from the url
    const[User , setUser] = useState({});
    useEffect(()=>{
       axios.get(`https://fakestoreapi.com/users/${params.id}`)
       .then((res) =>setUser(res.data))
       .catch(err=>console.log(err))     
    },[])
  return (
    <>
    <div>DetailedTodo</div>
    <div className='card'>
        <h3 className='card-title' >
            {User.email}
        </h3>
        <div className='card-body'>
            {User.name.firstname} ||
            {User.name.lastname}
        </div>
    </div>
    </>
  )
}

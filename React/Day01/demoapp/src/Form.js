import React, { useState } from 'react'
import UserData from './UserData';

export default function Form() {
 const [Name , setName] = useState();

 const SetUserName = (e)=>{
    console.log(e.target.value)
    setName(e.target.value)
 }

   
    return (
    <div className='container' > 
    <h2> Form Signup </h2>

    <input  type='text' onChange={(e)=>SetUserName(e)} placeholder='UserName' id='username' className='form-control'     />
    <UserData name={Name} />
    </div>
  )
}

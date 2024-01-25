import React from 'react'

export default function UserData(props) {
    console.log(props)
  return (
    <>
    <h2> hello From React</h2>

    { (props.name != null) ?  <h3>your name is : {props.name}</h3>: ""  }
    {(props.position) ? <h3>your Position is : {props.position}</h3>:"" }
    {(props.age)? <h3>your age is : {props.age}</h3> : ""}
    </>
  )
}

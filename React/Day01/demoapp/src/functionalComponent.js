import React, { useEffect, useState } from 'react'
import UserData from './UserData';
//public string products {get ; set;}
export default function FunctionalComponent() {
 //React Hooks Has Come ==>
 //1.state --> set ,get ==> useState() 
  // const [Name , setName] = useState("yousif")
  // const [age , setage] = useState(26)
  // const [position , setposition] = useState("Software Engineer")
  const [UserValue , setUserValue] = useState({
    name: "Yousif",
    age : 26 ,
    position:"SoftwareEngineer"
  });
  const [Products , setProducts] = useState();


//Did Mount 
  useEffect(()=>{
    //call api set state 

    console.log("Component Did Mount ")
  },[])//array of dependencies is empty ==>did mount 


  //Did Update 
  useEffect(()=>{
    console.log("UserValue Updated ")
  },[UserValue]) ////array of dependencies has obj so when updated logic will fire


 //Did Unmount 
useEffect(()=>{
  return () => {
    //clean your code while unmount 
  }
}) // function return function did UnMount

   const ChangeName = (name)=>{
    
    setUserValue({
      ...UserValue,
      name
    });
  }
let conditionalRendering  = "null";
let flag = false ;  
  return (
    <>
      { conditionalRendering ??  <UserData  name={UserValue.name} position={UserValue.position} age={UserValue.age}   /> }
      { flag ?  <UserData  name={UserValue.name} position={UserValue.position} age={UserValue.age}   /> 
          :<h1>no Data Available </h1>}
        <button onClick={()=> ChangeName("adel")}> Change your name 1 </button>
       <button onClick={()=> ChangeName("Ahmed")}> Change your name 2  </button>
    </>
  );
}


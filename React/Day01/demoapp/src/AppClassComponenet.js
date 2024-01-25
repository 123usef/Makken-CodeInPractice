import React from "react";
import UserData from "./UserData";

class AppClassComponent extends React.Component
{
    constructor(){
        super();
        let userValue = {
            name:"yousif",
            position : "SoftwareEngineer",
            age: 26
        }
        this.state = {...userValue}
        console.log("hello from Constructor") ;
    }
    //comes Alive
    componentDidMount(){
            console.log("Did Mount ")
    }
    //any update happened to the Component
    componentDidUpdate(){
        console.log("Updated")

    }
    //component will be removed 
    componentWillUnmount(){

    }
     ChangeName = (name)=>{
        console.log("Chnage name")
        this.setState({
            
            name
        })

    }

    render(){
        return(
            // fragment
            <>
                
           <UserData  name={this.state.name} position={this.state.position} age={this.state.age}  />
            <button onClick={()=>this.ChangeName("adel")}> Change your name 1 </button>
            <button onClick={()=>this.ChangeName("Ahmed")}> Change your name 2  </button>
            </>
            );
        }
}
export default AppClassComponent ;
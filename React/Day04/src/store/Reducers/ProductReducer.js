const InitialState = {
    cnt : 0,
    isloading:true
}

const ProductReducer =(state = InitialState , action )=>{
    switch(action.type){
        case "INCREASECOUNT":
            return {
                ...state, 
                cnt : state.cnt + action.payload
            }
        case "Loading" :
            return {
                ...state,
                isloading : action.payload
            }    
        default :
        return state ;    
    }
}
export default ProductReducer ;
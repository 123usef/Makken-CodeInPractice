export const IncreaseCart = (payload)=>{
  return  {
        type:"INCREASECOUNT",
        payload
    }
}

export const isLoader = (payload)=>{
    return {
        type:"Loading",
        payload
    }
}

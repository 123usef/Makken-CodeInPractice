const InitalState = {
    lang : "en",
    conut:0
}

const  LanguageReducer = (state = InitalState , action) =>
{
    switch (action.type){
        case "CHANGELANGUAGE":
            return({
                ...state ,
                lang : action.payload
            });
        default :
            return ({
                ...state
            }) ;   
    }
    
}

export default LanguageReducer ; 
import { combineReducers } from "redux";
import LanguageReducer from "./Reducers/Languagereducer";
import ProductReducer from "./Reducers/ProductReducer"

const combinedReducers = combineReducers({
    language : LanguageReducer, 
    count : ProductReducer
}
)
export default combinedReducers ;

import { combineReducers, configureStore } from '@reduxjs/toolkit' ;
import LanguageReducer from './Reducers/Languagereducer' ;
import combinedReducers from './CombinedReducer';


const store = configureStore({
    reducer : combinedReducers,
   
  });
// const store = createStore(LanguageReducer , composeWithDevTools())

export default store ;
// import {configureStore} from "@reduxjs/toolkit";
import { configureStore } from '@reduxjs/toolkit' ;
import LanguageReducer from './reducer' ;

const store = configureStore({
    reducer : LanguageReducer,
})

export default store ;
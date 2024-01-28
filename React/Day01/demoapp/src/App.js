import logo from './logo.svg';
import pic from "./pic.png";
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import Form from './Form';
import AppClassComponent from './AppClassComponenet';
import FunctionalComponent from './functionalComponent';
import { BrowserRouter as Router ,Routes , Route } from 'react-router-dom';


import BasicExample from './BasicExample';
function App() {
  
  return (
    // <div className="App">
      
    //   {/* <AppClassComponent /> */}
    //   <FunctionalComponent />
    //   <Form />
    //   {/* <FunctionalComponent /> */}
    //   {/* <BasicExample /> */}
    // </div>
    <Router>
      <Routes>
        <Route path='/' element={<FunctionalComponent/>}  />
        
      </Routes>
    </Router>
  );
}

export default App;

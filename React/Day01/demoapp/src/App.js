import logo from './logo.svg';
import pic from "./pic.png";
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import Form from './Form';
import AppClassComponent from './AppClassComponenet';
import FunctionalComponent from './functionalComponent';

import BasicExample from './BasicExample';
function App() {
  
  return (
    <div className="App">
      
      {/* <AppClassComponent /> */}
      <FunctionalComponent />
      <Form />
      {/* <FunctionalComponent /> */}
      {/* <BasicExample /> */}
    </div>
  );
}

export default App;

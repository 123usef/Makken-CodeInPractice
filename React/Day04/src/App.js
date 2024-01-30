import logo from './logo.svg';
//React Imports 

//Styling Imports 
import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';
//Componenets Imports 
import Navbar from './Components/nav/Navbar';
import Footer from './Components/footer/Footer';
import Home from './Pages/Home/Home';
import TodoList from './Pages/Todo/TodoList/TodoList';
import AddTodo from './Pages/Todo/AddTodo/AddTodo';
import DetailedTodo from './Pages/Todo/DetailedTodo/DetailedTodo';
//routing Imports 
import { BrowserRouter as Router , Routes , Route } from 'react-router-dom';
import NotFound from './Pages/NotFound/NotFound';
import { useSelector } from 'react-redux';

function App() {  
  const lang  = useSelector((state) => state.language.lang);
  return (
  <>
  <div className='' dir={lang == "en" ? "ltr" :"rtl"}>
   <Router>
   <Navbar />
      <Routes>
        
        <Route path='/' element={<Home />}  />
        <Route path='/listTodo' element={<TodoList />} />
        {/*  params through the Url is Accessed Through the useParams() --> hook   */}
        <Route path='/detailedTodo/:id' element={<DetailedTodo />} />
        <Route path='/AddTodo' element={<AddTodo />} />
        <Route path='*' element= {<NotFound />}  />
      </Routes>
      <Footer />
   </Router>
  </div>
  
  </>
  );
}

export default App;
/*
Configuring Routing inside our Application 
1.npm install react-router-dom 
2. configure the component Store "App.js"
  1.import nesscary Imports 
      import { BrowserRouter as Router , Routes , Route } from 'react-router-dom';
  then create the Structure 
  Router 
    static elements over the WebSite
    Routes
      Route path ="url" element={<Component />} />
      Route path ="url" element={<Component />} />
      Route path ="url" element={<Component />} />
    Routes
    Static Element over Website 
  Router  

*/
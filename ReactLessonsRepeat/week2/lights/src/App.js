import './App.css';
import React from 'react';
import * as ReactDOM  from 'react-dom';
import TrafficLight from "./components/TrafficLight";
import "./styles.css";

function App() {
  return (
    <div className="App">
    <TrafficLight initialValue={0}/>
    <TrafficLight initialValue={1}/> 
    <TrafficLight initialValue={2}/>
   
    </div>
  );
}
const rootElement = document.getElementById("root");
ReactDOM.render(<App />, rootElement);
export default App;

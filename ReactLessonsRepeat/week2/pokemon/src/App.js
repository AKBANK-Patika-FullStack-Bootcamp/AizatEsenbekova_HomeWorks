import Pokemon from "./components/Pokemon";
import React from "react";
import './App.css';

function App() {
  const pokemonList=[
    {name:"Aizat", id:1, height:157},
    {name:"MK", id:2, height:180},
    {name:"Anisa", id:3, height:162},
    {name:"Zalkar", id:4, height:undefined} //undefined olunca default değeri almış oluyor
  ]
  return (
    <div className="App">
    <div className="App-header">
      {/*<Pokemon pokemonName={pokemonList[0].name} pokemonHeight={pokemonList[0].height}/>
      <Pokemon pokemonName={pokemonList[1].name} pokemonHeight={pokemonList[1].height}/>
      <Pokemon pokemonName={pokemonList[2].name} pokemonHeight={pokemonList[2].height}/>
      <Pokemon pokemonName={pokemonList[3].name} pokemonHeight={pokemonList[3].height}/> */
      pokemonList.map((pokemon,index)=>
      {
        return <Pokemon  pokemonName={pokemon.name} pokemonHeight={pokemon.height} key={index}/>
      })
      }
    </div>
    </div>
  );
}

export default App;

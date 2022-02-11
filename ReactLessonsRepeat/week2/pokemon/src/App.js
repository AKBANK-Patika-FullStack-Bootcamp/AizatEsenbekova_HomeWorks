import Pokemon from "./components/Pokemon";
import React, {useEffect, useState} from "react";
import './App.css';
import axios from "axios";

function App() {
  /*const pokemonList=[
    {name:"Aizat", id:1, height:157},
    {name:"MK", id:2, height:180},
    {name:"Anisa", id:3, height:162},
    {name:"Zalkar", id:4, height:undefined} //undefined olunca default değeri almış oluyor
  ]*/
  const [pokeList, setPokeList]=useState([]);
  const [isActive , setActive]= useState();

  useEffect(()=>{axios.get("https://pokeapi.co/api/v2/pokemon")
  .then((response)=>{
  console.log(response.data.results);
  const tempList=response.data.results.slice(0,5);
  const PokewithHeight=tempList.map((poke)=>{
    return {...poke, height:Math.floor(Math.random()*10+1)}})
  setPokeList(PokewithHeight);});
},[])
  
 
  return (
    <div className="App">
    <div className="App-header">
      {/*<Pokemon pokemonName={pokemonList[0].name} pokemonHeight={pokemonList[0].height}/>
      <Pokemon pokemonName={pokemonList[1].name} pokemonHeight={pokemonList[1].height}/>
      <Pokemon pokemonName={pokemonList[2].name} pokemonHeight={pokemonList[2].height}/>
      <Pokemon pokemonName={pokemonList[3].name} pokemonHeight={pokemonList[3].height}/> */
      pokeList.map((pokemon,index)=>
      {
        return <Pokemon  isActive={isActive===pokemon.name} 
        setActive={setActive}
        pokemonName={pokemon.name}
        pokemonHeight={pokemon.height} 
        key={index}/>
      })
      }
    </div>
    </div>
  );
}

export default App;

import PropType from "prop-types";
import React,{useState} from "react";

const Pokemon=({isActive, setActive, pokemonName:name,pokemonHeight:height=150})=>{
    
    /*const date = new Date();
    const formattedDate= date.toDateString();
    */
   const [newHeight, setNewHeight] = useState(height);
   const onClickPokemon= async()=>{
       await setNewHeight(newHeight+1);
   }

   const activeHandle=()=>{
       setActive(name);
   }
    return(
        <>
        <div style={{border:`1px solid ${isActive ? 'red':'white'}`}} onClick={activeHandle}>
            <div>{name}</div>
            <div>{newHeight}</div>
            {
                isActive ? <button onClick={onClickPokemon}>Update height</button>:null
            }
          
        </div>
        <br></br>
        </>
    );
};
Pokemon.propTypes={
    pokemonName:PropType.string,
    pokemonHeight:PropType.number,
    isActive: PropType.bool,
    setActive: PropType.func
};

// Pokemon.defaultProps={
//     pokemonHeight:150,
//     pokemonName:"isimsiz"
// }

export default Pokemon;
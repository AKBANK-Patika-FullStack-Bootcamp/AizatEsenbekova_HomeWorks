import PropType from "prop-types";

const Pokemon=({pokemonName:name,pokemonHeight:height=150})=>{
    
    /*const date = new Date();
    const formattedDate= date.toDateString();
    */
    return(
        <>
        <div style={{border:"1px solid white"}}>
            <div>{name}</div>
            <div>{height}</div>
        </div>
        <br></br>
        </>
    );
};
Pokemon.propTypes={
    pokemonName:PropType.string,
    pokemonHeight:PropType.number
};

// Pokemon.defaultProps={
//     pokemonHeight:150,
//     pokemonName:"isimsiz"
// }

export default Pokemon;
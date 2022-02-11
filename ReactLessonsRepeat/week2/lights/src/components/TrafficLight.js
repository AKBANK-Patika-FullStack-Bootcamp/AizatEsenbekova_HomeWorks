import React,{useEffect, useState} from "react";
import Light from "./Light";

const lightDuration=[3000,2000,1000];
const TrafficLight=({initialValue})=>{
    const [colorIndex, setColorIndex]=useState(initialValue);
    useEffect(()=>{
        const timer=setTimeout(()=>{
            setColorIndex((colorIndex+1)%3);},
            lightDuration[colorIndex]);
            return()=>{
                clearTimeout(timer);
            };

    });
    return(
        
        <div className="traffic-light">
            <Light color="#FF0000" active={colorIndex===0}/>
            <Light color="#FFFF00" active={colorIndex===1}/>
            <Light color="#00FF00" active={colorIndex===2}/>
        </div>
       
    
       
    )

}

export default TrafficLight;
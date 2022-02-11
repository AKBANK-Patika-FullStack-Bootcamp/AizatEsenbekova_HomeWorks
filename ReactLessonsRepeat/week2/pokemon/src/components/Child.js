import React, { useImperativeHandle } from "react";
const Child=React.forwardRef(({actionButtons,...props},ref)=>{
    
    const childFunc=()=>{
        console.log("Çocuk!");
    }

    useImperativeHandle(ref,()=>({
        childFunc
    }));
    return(
        <>
        <div onClick={props.onClick}> Say Hi!</div>
        </>
    )})

export default Child;
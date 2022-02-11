import React from "react";
import Child from "./Child"
import { useRef } from "react";

const Parent=((props)=>{
const myRef=useRef();

const parentFunc=(()=>console.log("babaaa"));
const onClickFunc=()=>myRef.current?.childFunc();

return(
    <>
    <Child ref={myRef} onClick={parentFunc}/>
    <button onClick={onClickFunc}> Say Bye! </button>
    </>
)
}
)

export default Parent;
import React from "react";
import Child from "./Child"
const Parent=(()=>{
const parentFunc=(()=>console.log("babaaa"));

return(
    <>
    <Child parentFunc={parentFunc}/>
    <button onClick={parentFunc}> Say Bye! </button>

    </>
)
}
)

export default Parent;
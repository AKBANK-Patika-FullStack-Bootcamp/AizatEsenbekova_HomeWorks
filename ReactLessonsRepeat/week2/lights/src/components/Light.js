import React from "react";

const Light=({color,active})=>{
return(
<div className="light"
    style={{  
    appearance: "none",
    position: "relative",
    left: "50%",
    width: 80,
    height: 80,
    marginTop: 20,
    marginLeft: -40,
    verticalAlign: "middle",
    borderRadius: "100%",
    display: "block",
    backgroundColor:color,
    opacity:active ? 1: 0.4}}
>
&nbsp;
</div>)
}

export default Light;
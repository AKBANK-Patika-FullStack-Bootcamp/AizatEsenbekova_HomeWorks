
const Child=(({parentFunc})=>{
    const childFunc=(()=>{
        console.log("Çocuk!");
    })
    return(
        <>
        <div onClick={parentFunc}> Say Hi!</div>
        </>
    )
})

export default Child;
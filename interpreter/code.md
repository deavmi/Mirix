Code System
===========

I want to be able to parse the whole program text and then generate the code block for each declared function.


````
function main()
{
    println("Hello world");
    doThing();
}


function doThing()
{
    return;
}
````

This would then be parsed and a `ProgramData` object would be made. It will hold an array of all of the `Functions`. When we begin execution we have a pointer to the entry `Function` object (which would be `main`).
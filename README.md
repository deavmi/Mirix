Mirix
=====

![](https://ci.appveyor.com/api/projects/status/a54ip6aeofk790uf?svg=true)

**Mirix** is a highly awesome interpreted language that you will really want to use. It is written in C# so that we can get it running everywhere due to .NET Core being available on Windows, Linux and Max OSX these days (for x86 and ARM).

## A taste of Mirix

An example program is written below:

````
function main()
{
    println("Hello and welcome to the world or Mirix!");
}
````

## Internals

So the lexer generates tokens. These tokens are then passed to the parser which generates code from them.

### Data during runtime

We implement a stack-like system where each frame of the `Stack` is a `StackFrame` by which each function call runs on a new `StackFrame` where it can modify its local variables.

There is also a `Heap` that can be accessed anywhere.

### Execution

It may make sense to allow each Instruction to have access to the r=current program as to maniulate it like that and then we need not add specifics in to our `Executor`.
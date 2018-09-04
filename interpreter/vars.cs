namespace Mirix.Interpreter.Language
{
    using System.Collections.Generic;
    using System;

    namespace Variables
    {
        public sealed class Variable
        {
            private string identifier;

            //The variable's type
            private Type type;
        }
    }

    //Representations of values in the Mirix language
    namespace Values
    {
        //Represents a value in the Mirix language
        public class Value
        {

        }

        //Related types to Scalars
        namespace Scalar
        {
            //Represents a scalar value in the Mirix language
            public class Scalar : Value
            {
                //When constructig make sure the input value is of the given type
                public Scalar()
                {

                }

            }

            //Byte
            public sealed class BuiltInByte : Scalar
            {
                //The value
                byte value;

                public BuiltInByte(byte value)
                {
                    this.value = value;
                }
            }

            //Short (2 bytes)
            public sealed class BuiltInShort : Scalar
            {
                //The value
                short value;

                public BuiltInShort(short value)
                {
                    this.value = value;
                }
            }

            //Integer (4 bytes)
            public sealed class BuiltInInt32 : Scalar
            {
                //The value
                Int32 value;

                public BuiltInInt32(Int32 value)
                {
                    this.value = value;
                }
            }

            //Integer (8 bytes)
            public sealed class BuiltInInt64 : Scalar
            {
                //The value
                Int64 value;

                public BuiltInInt64(Int64 value)
                {
                    this.value = value;
                }
            }
        }



        //Related types to Records
        namespace Record
        {
            //Represents a non-scalar but rather struct type in the Mirix language (composed of multiple `Value`(s))
            public sealed class Record : Value
            {
                //The elements of the record
                //TODO default compare kak for dictiary
                private Dictionary<string, Value> recordElements = new Dictionary<string, Value>();

                //Construct a new Record
                public Record()
                {

                }

                //Add an element to the record
                public void addElement(Value value, string recordElementName)
                {
                   //TODO add me recordElements.Add(value, );
                }
            }
        }


    }

    namespace Types
    {
        //Represents a type in the Mirix language
        public class Type
        {
            //The name of the type
            private string typeName;

            public Type(string typeName)
            {
                this.typeName = typeName;
            }
        }

        //Represents a built-in type
        //TODO

        //Represents a non-scalar (user defined basis) type
        //TODO

        public sealed class StructType
        {

        }

        //Represents a scalar ref type 

        namespace BuiltIns
        {

        }
    }

}
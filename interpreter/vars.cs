namespace Mirix.Interpreter.Language
{
    using System.Collections.Generic;

    namespace Variables
    {
        public sealed class Variable
        {
            private string identifier;

            //The variable's type
            private Types type;
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
                //Because these are built-in to the language there are only a the below mentioned types
                public enum BuiltInType
                {
                    //byte, word (2 bytes), int (4 bytes), int (8 bytes)
                    typeByte, typeShort, typeInt32, typeInt64;
                }

                //When constructig make sure the input value is of the given type
                public Scalar()
                {

                }

            }

            //Byte
            public sealed class BuiltInByte : Scalar
            {

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

            }

            //Integer (8 bytes)
            public sealed class BuiltInInt64 : Scalar
            {

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
                private Dictionary<string, Value> recordElements = new Dictionary<string,Value>();

                //Construct a new Record
                public Record()
                {

                }

                //Add an element to the record
                public void addElement(Value value, string recordElementName)
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
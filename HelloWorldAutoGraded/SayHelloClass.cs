using System;
namespace HelloWorldAutoGraded
{
	public class SayHelloClass
    {
        //Update the method to pass the auto-graded test

		public static string SayHello()
		{
			return "Hello, World!";
		}

        //class constructor - intentionally empty
        public SayHelloClass()
        {

        }
    }

    internal record struct NewStruct(object Item1, object Item2)
    {
        public static implicit operator (object, object)(NewStruct value)
        {
            return (value.Item1, value.Item2);
        }

        public static implicit operator NewStruct((object, object) value)
        {
            return new NewStruct(value.Item1, value.Item2);
        }
    }

    internal record struct NewStruct1(object Item1, object Item2)
    {
        public static implicit operator (object, object)(NewStruct1 value)
        {
            return (value.Item1, value.Item2);
        }

        public static implicit operator NewStruct1((object, object) value)
        {
            return new NewStruct1(value.Item1, value.Item2);
        }
    }
}


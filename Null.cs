using System;
using System.Dynamic;
using ImpromptuInterface;

namespace UnitTests
{
    public class Null<T> : DynamicObject    where T    : class
    {
        public static T Instance
        {
            get { return new Null<T>().ActLike<T>(); }
        }
        
        public override bool TryInvokeMember(InvokeMemberBinder binder, 
            object[] args, out object result)
        {
            result = Activator.CreateInstance(
                typeof(T).GetMethod(binder.Name).ReturnType
            );
            return true;

        }
    }
}
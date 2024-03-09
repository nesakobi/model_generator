namespace ModelGenerator.Common.Helpers
{
    public enum PropertyType
    {
        Boolean,                    // bool
        Symbol,                     // char
        String,                     // string
        SmallInteger,               // sbyte
        Integer,                    // int
        BigInteger,                 // long
        UnsignedSmallInteger,       // byte
        UnsignedInteger,            // uint
        UnsignedBigInteger,         // ulong
        FloatingPoint,              // float
        LongFloatingPoint,          // double
        Decimal,                    // decimal
        Dynamic,                    // dynamic
        Object,                     // object
        Generic,                    // generic types
        Custom                      // user defined struct/class/interface ...
    }

    public enum OOPType
    {
        Structure,
        Class,
        Interface,
        Record
    }

    public enum OOPTypeMark
    {
        None,
        Abstract,
        Sealed
    }

    public enum AccessModifier
    {
        Public,
        PublicAndInternal,
        Protected,
        Internal,
        PrivateAndProtected,
        Private
    }
}

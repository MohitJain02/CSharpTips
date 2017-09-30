namespace GenericMethodUsingImplicitTyping
{
    internal struct StructWithOverrideAndReferenceType
    {
        public int Value1 { get; set; }

        public int Value2 { get; set; }

        public string Description { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is StructWithOverrideAndReferenceType))
            {
                return false;
            }

            var actualObj = (StructWithOverrideAndReferenceType) obj;

            return Value1 == actualObj.Value1
                   && Value2 == actualObj.Value2
                   && Description == actualObj.Description;
        }
    }
}

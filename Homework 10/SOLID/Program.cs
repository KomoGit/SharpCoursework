namespace Solid
{
    public interface IRProperty
    {
        string GetPropertyValue();
    }

    public class RProperty1 : IRProperty
    {
        protected internal string MyProperty1 { get; set; }

        public string GetPropertyValue()
        {
            return MyProperty1;
        }
    }

    public class RProperty2 : IRProperty
    {
        protected internal string MyProperty2 { get; set; }

        public string GetPropertyValue()
        {
            return MyProperty2;
        }
    }

    class ROperation
    {
        public string GetValuesFromRObjects<T>(IEnumerable<T> objects) where T : IRProperty
        {
            string type = typeof(T).Name;
            var list = new string[5];
            if (type == typeof(RProperty1).Name)
            {
                list = ((IEnumerable<IRProperty>)objects).Select(x => x.GetPropertyValue()).ToArray();
            }
            else if (type == typeof(RProperty2).Name)
            {
                list = ((IEnumerable<IRProperty>)objects).Select(x => x.GetPropertyValue()).ToArray();
            }
            return $"Correct values : {String.Join(',', list)}";
        }
    }
}
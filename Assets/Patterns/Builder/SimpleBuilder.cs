namespace Patterns.Builder
{
    public abstract class AbstractSimpleBuilder
    {
        public abstract ObjectToBuild Build();
    }

    public class SimpleBuilder : AbstractSimpleBuilder
    {
        private int _a;
        private int _b;
        private int _c;

        public SimpleBuilder WithA(int a)
        {
            _a = a;

            return this;
        }

        public SimpleBuilder WithB(int b)
        {
            _b = b;

            return this;
        }

        public SimpleBuilder WithC(int c)
        {
            _c = c;

            return this;
        }

        public override ObjectToBuild Build()
        {
            return new ObjectToBuild {A = _a, B = _b, C = _c};
        }
    }
}
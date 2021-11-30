namespace Patterns.Builder
{
    public class ObjectToBuild
    {
        public int A;
        public int B;
        public int C;

        public override string ToString()
        {
            return $"{nameof(ObjectToBuild)} {{A = {A}, B = {B}, C = {C}}}";
        }
    }
}
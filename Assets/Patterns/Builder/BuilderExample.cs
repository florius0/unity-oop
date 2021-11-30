using UnityEngine;

namespace Patterns.Builder
{
    public class BuilderExample : MonoBehaviour
    {
        private void Start()
        {
            var o = new SimpleBuilder().WithA(1).WithB(2).WithC(3).Build();

            Debug.Log(o);
        }
    }
}
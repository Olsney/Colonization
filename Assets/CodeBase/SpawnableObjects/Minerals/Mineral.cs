using UnityEngine;

namespace CodeBase.SpawnableObjects.Minerals
{
    public class Mineral : MonoBehaviour, IMineral
    {
        public Vector3 Position => transform.position;

        public void Initialize(Vector3 position) => 
            transform.position = position;

        public void Bind(Transform transformToBind) => 
            transform.parent = transformToBind;
    }
}
using CodeBase.Castles;
using UnityEngine;

namespace CodeBase.Services
{
    public class CastleFactory : MonoBehaviour
    {
        [SerializeField] private Castle _castlePrefab;
        
        public Castle Create(Vector3 position)
        {
            Castle castle = Instantiate(_castlePrefab, position, Quaternion.identity, null);
            castle.Construct();
            
            float positionY = castle.transform.position.y + (castle.transform.localScale.y / 2f);
            castle.Initialize(new Vector3(castle.transform.position.x, positionY, castle.transform.position.z));
            
            return castle;
        }

        public void Construct(Castle castlePrefab) => 
            _castlePrefab = castlePrefab;
    }
}
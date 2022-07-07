using UnityEngine;

namespace Sagasi.Core
{
    public class TargetObject : MonoBehaviour
    {
        [SerializeField] private GameObject particle;

        [SerializeField] private Transform particleRoot;

        private void Awake()
        {
            Debug.Log("awake");
        }

        public void TestLog()
        {
            var instance = GameObject.Instantiate(particle, particleRoot);
            instance.transform.position = transform.position;
        }
    }
}
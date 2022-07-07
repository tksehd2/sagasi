using System;
using UnityEngine;

namespace UI
{
    public class TestButton : MonoBehaviour
    {
        [SerializeField] private GameObject particle;

        [SerializeField]
        private Transform particleRoot;

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
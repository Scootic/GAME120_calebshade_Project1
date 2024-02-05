using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Horrible
{
    public class kirk_eyes : MonoBehaviour
    {
        [SerializeField] private GameObject[] eyes;
        // Start is called before the first frame update

        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player") { foreach (GameObject eye in eyes) { eye.SetActive(true); } }

        }

        private void OnTriggerExit(Collider other)
        {
            if (other.tag == "Player") { foreach (GameObject eye in eyes) { eye.SetActive(false); } }
        }
    }
}

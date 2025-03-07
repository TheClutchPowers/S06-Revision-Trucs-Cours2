using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollecteurAvecEvenement : MonoBehaviour
{
    public UnityEvent OnCollecterPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Monnaie"))
        {
            OnCollecterPoint.Invoke();
            Destroy(other.gameObject);
        }
    }
}

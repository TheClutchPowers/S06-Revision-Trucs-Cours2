using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
     public int _temps;
     [SerializeField] private TextMeshProUGUI _etiquettePoints;
    // Start is called before the first frame update
    void Start()
    {
        _temps = 0;
        InvokeRepeating("CompterSecondes",1f, 1f);
    }

    // Update is called once per frame
    void CompterSecondes()
    {
        _temps +=1;
        _etiquettePoints.text = _temps + "s".ToString();
    }
}

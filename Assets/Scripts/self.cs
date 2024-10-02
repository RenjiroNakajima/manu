using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class self : MonoBehaviour
{
    [SerializeField]
    Scorescript Scorescript;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);

        Scorescript.RemoveScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

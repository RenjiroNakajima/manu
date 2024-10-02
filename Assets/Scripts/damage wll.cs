using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class damagewll : MonoBehaviour
{
    void OnCollisionEnter(Collision collison)
    {
        SceneManager.LoadScene("game scene");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorescript : MonoBehaviour
{
    [SerializeField]
    TMPro.TextMeshProUGUI scoreText;

    [System.NonSerialized]
    public int numberOfItem;

    public void RemoveScore()
    {
        --numberOfItem;

        scoreText.SetText("Žc‚è{0}ŒÂ", numberOfItem);
    }
    // Start is called before the first frame update
    void Start()
    {
        numberOfItem = 9;
        scoreText.SetText("Žc‚è{0}ŒÂ", numberOfItem);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

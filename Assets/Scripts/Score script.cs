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

        scoreText.SetText("�c��{0}��", numberOfItem);
    }
    // Start is called before the first frame update
    void Start()
    {
        numberOfItem = 9;
        scoreText.SetText("�c��{0}��", numberOfItem);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerascript : MonoBehaviour
{
    [SerializeField]
    Transform playerTransform;
    Vector3 playerPosition;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        playerPosition = playerTransform.position;
        offset = gameObject.transform.position - playerPosition;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerPosition = playerTransform.position;
        gameObject.transform.position = playerPosition + offset;
    }
}

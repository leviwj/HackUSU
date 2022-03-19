using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScroller : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1;

    // Update is called once per frame
    void Update()
    {
        // scroll ground +unit per frame
        transform.Translate(new Vector3(0, 0, -moveSpeed * Time.deltaTime));
    }
}

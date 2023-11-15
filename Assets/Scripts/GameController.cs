using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private bool isActive = false;
    [SerializeField] GameObject dragableAsset;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(dragableAsset.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        // dragableAsset.transform.position.x += 0.01;
    }
}

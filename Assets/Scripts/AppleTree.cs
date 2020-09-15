using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Prefab Settings")]
    public GameObject applePrefab;
    public float speed=1f;
    //how fast the tree moves
    public float radius=10f;
    //distance the tree moves across the screen
    public float directionChangeChance =0.1f;
    //how often tree changes direction
    public float dropSpeed= 1f;


    // Start is called before the first frame update
    void Start()
    {
        //dropping apples every second
    }

    // Update is called once per frame
    void Update()
    {
        //basic movement
        //change diretction 

    }
}

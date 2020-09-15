using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ApplePicker : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("set in inspector")]
    public GameObject basketPrefab;
    public int numberOfBaskets = 3;
    public float basketBottom = -14f;
    public float basketSpacing = 2f;

    void Start()
    {
        for(int i=0; i<numberOfBaskets; i++)
        {
            GameObject tBasketGO = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottom +( basketSpacing*i);
            tBasketGO.transform.position = pos;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

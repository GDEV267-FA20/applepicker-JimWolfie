using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("set in inspector")]
    public GameObject basketPrefab;
    public int numberOfBaskets = 3;
    public float basketBottom = -14f;
    public float basketSpacing = 2f;
    public List<GameObject> basketList;

    void Start()
    {
        basketList = new List<GameObject>();
        for(int i=0; i<numberOfBaskets; i++)
        {
            
            GameObject tBasketGO = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottom +( basketSpacing*i);
            tBasketGO.transform.position = pos;
            basketList.Add(tBasketGO);
        }
    }
    public void AppleDestroyed()
    {
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach(GameObject tgo in tAppleArray)
        {
            Destroy(tgo);
        }
        int basketIndex = basketList.Count-1;
        GameObject tBasketGO = basketList[basketIndex];
        basketList.RemoveAt(basketIndex);
        Destroy(tBasketGO);
        if (basketList.Count == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

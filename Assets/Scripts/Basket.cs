using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;


public class Basket : MonoBehaviour
{
    BasketMove controls;
    public TextMeshProUGUI scoreGT;

    private void Awake()
    {
        controls = new BasketMove();

    }
    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        scoreGT = scoreGO.GetComponent<TextMeshProUGUI>();
        scoreGT.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos2D = controls.Mouse.Position.ReadValue<Vector2>();
        
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;

    }
    private void OnCollisionEnter(Collision collision)
    {
        GameObject collidedWith = collision.gameObject;
        if(collidedWith.tag == "Apple")
        {
            Destroy(collidedWith);
            SetCount();
        }
    }
    private void SetCount()
    {
        int score = int.Parse(scoreGT.text);
        score +=100;
        scoreGT.text = score.ToString();
        if(score > HighScore.score)
        {
            HighScore.score = score;
        }
    }
}

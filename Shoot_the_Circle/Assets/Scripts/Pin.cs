using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{

    private bool isPinned = false;

    public float speed = 20f;
    public Rigidbody2D rb;

    void Update()
    {
        if (!isPinned)
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            //Score.PinCount++;
            col.GetComponent<Rotator>().speed += 10f; //increases speed 
            //col.GetComponent<Rotator>().speed *= -1f; //inverse the rotation
            isPinned = true;
        }
        else if (col.tag == "Pin")
        {
            
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}

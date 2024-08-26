using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    //private float jumpForce = 10f;
    public PlatformMove Instance;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.down * Time.deltaTime * 2);
        
    }

    // private void OnCollisionEnter2D(Collision2D collision)
    // {
    //     if (collision.gameObject.tag == "Player")
    //     {
    //         collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpForce;
    //     }
    // }

    // This will be called in PlatformPhasing script
    // when the player lands on the platform, move each platform down quickly by 10
    public void PlatformDown()
    {
        transform.Translate(Vector3.down * Time.deltaTime * 10);
    }
}

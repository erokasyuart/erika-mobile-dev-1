using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    //private float jumpForce = 10f;
    public PlatformMove Instance;
    private int lastHeight = 0;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.height > lastHeight)
        {
            lastHeight = GameManager.height;
            PlatformDown();
        }
        
    }

    // This will be called in PlatformPhasing script
    // when the player lands on the platform, move each platform down quickly by 10
    public void PlatformDown()
    {
        transform.Translate(Vector3.down * Time.deltaTime * 10);
    }
}

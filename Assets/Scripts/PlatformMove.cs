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

   
}

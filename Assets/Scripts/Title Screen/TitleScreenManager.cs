using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScreenManager : MonoBehaviour
{
    [SerializeField] private ParticleSystem shipEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PlayBoostEffect()
    {
        if (Input.GetMouseButton(0))
        {
            shipEffect.Play();
        }
        else
        {
            shipEffect.Stop();
        }
    }

}

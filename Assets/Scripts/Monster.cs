using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class Monster : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5.5f)
        {
            Destroy(gameObject);
        }
    }
}

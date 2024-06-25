using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleExplosion_ : MonoBehaviour
{
    private UnityEngine.Object explosionRef;
    // Start is called before the first frame update
    void Start()
    {
        explosionRef = Resources.Load("Explosion");
    }

    public void GetExplosion()
    {
        GameObject explosion = (GameObject)Instantiate(explosionRef);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

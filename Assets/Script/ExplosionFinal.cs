using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionFinal : MonoBehaviour
{
    public UnityEngine.Object explosionref;

    private void Start()
    {
        explosionref = Resources.Load("Explosion");
    }

    public void GetExplosion()
    {
        GameObject explosion = (GameObject)Instantiate(explosionref);
    }
}

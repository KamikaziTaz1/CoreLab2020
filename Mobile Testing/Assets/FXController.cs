using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//class to spawn explosions wherever we want
public class FXController : MonoBehaviour
{

    public ParticleSystem explodePrefab;
    // Start is called before the first frame update
    void Start()
    {
        SpawnExplosion(new Vector3(1f, 1f, 1f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //spawn/instantiate explosion wherever
    public ParticleSystem SpawnExplosion(Vector3 pos){
        ParticleSystem effect = Instantiate(explodePrefab, pos, Quaternion.identity, this.transform) as ParticleSystem; //"as" function prevents type mismatch

        Destroy(effect, effect.main.duration);//should last only as long as duration of particlesystem
        return(effect);
    }
}

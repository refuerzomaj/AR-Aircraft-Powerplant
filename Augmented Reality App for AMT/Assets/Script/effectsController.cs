using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effectsController : MonoBehaviour
{
public ParticleSystem particleObject;
    public void playEffects(){
    particleObject.Play();
}
    public void stopEffects(){
    particleObject.Stop();
}
}

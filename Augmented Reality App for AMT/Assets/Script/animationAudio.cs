using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationAudio : MonoBehaviour
{
    public AudioSource sE,dA,a;
    public void startEngineAudio(){
        sE.Play();
    }
    public void stopEngineAudio(){
        sE.Stop();
    }
    public void disassembleAudio(){
        dA.Play();
        a.Stop();
    }
    public void assembleAudio(){
        dA.Stop();
        a.Play();
    }
}

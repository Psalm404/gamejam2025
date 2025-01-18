using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager Instance;
    public AudioSource clickUI;
    public AudioSource uncorkBottle;
    public AudioSource pourWine;
    public AudioSource pourWine2;
    public AudioSource phoneRing;
    public AudioSource answerPhone;
    public AudioSource colorPaint;
    public AudioSource rotateCell;
    public AudioSource slideCell;
    public AudioSource drinkWine2;
    public AudioSource glassCrash;
    public AudioSource waterWoosh;
    public AudioSource afterWaterWoosh;
    public AudioSource sinkInWater;
    public AudioSource handOpen1;
    public AudioSource handOpen2;
    public AudioSource handOpen3;
    public AudioSource bubbleCrash;
    public AudioSource heartBeat;
    public AudioSource heartSwell;
    public AudioSource heartToBubble;
    public AudioSource bubbleCrash2;
    public AudioSource summer;
    public AudioSource slideItem;
    public AudioSource interval;
    public AudioSource softMusic;
    public AudioSource openGift;
    public AudioSource screenShake;
    public AudioSource write;
    public AudioSource nightSound;
    public AudioSource shot;
    public AudioSource turnPage;
    public AudioSource dududu;
    public AudioSource laugh;
    public AudioSource clockTick;
    public AudioSource turnPageQuick;
    public AudioSource sadMusic;
    public AudioSource warmMusic;
    public AudioSource scissorCut;
    public AudioSource smile;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Debug.LogError("Multiple instances of AudioManager found!");
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    public static AudioManager GetInstance()
    {
        return Instance;
    }
    
}

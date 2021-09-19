using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class newzealand : MonoBehaviour
{// Start is called before the first frame update
    public GameObject Magic8Text;

    //array of 8ball sayings
    public static string[] sayings = {"( ͡° ͜ʖ ͡° )", "SHEEEESH", "Bussin", "Ye", "Swipe Right", "Bet", "Winner winner chicken dinner",
        "Idk", "L8r", "¯\\_(ツ)_/¯", "TTYL", "huh", "confuzzled", "discombobulating", "(╥_╥)", "Yikes", "Swipe Left", "SMH", "Nahhh" ,
        "F", "Dicey"};
    public static System.Random random = new System.Random();
    public AudioSource vietfx;
    public AudioClip vietfx2;

    void Start()
    {
        InvokeRepeating("getRandSaying", 2f, 1f);
        vietfx = GetComponent<AudioSource>();
    }

    void getRandSaying()
    {
        if (transform.up.y < 0f)
        {
            int randomSaying = random.Next(0, sayings.Length);
            Magic8Text.GetComponent<TextMeshPro>().text = "" + sayings[randomSaying];
            vietfx.clip = vietfx2;
            vietfx.Play();
            Debug.Log(sayings[randomSaying]);
        }
        else
        {
            Debug.Log("right side up");
        }
    }

}



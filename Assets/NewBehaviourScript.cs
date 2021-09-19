using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class NewBehaviourScript : MonoBehaviour
{// Start is called before the first frame update
    public GameObject Magic8Text;
    public AudioSource vietfx;
    public AudioClip vietfx2;

    //array of 8ball sayings
    public static string[] sayings = {"It is Certain", "It is decidedly so", "Without a doubt", "Yes definitely", "You may rely on it",
                "As I see it, yes.", " Most likely", "Outlook good", "Yes", "Signs point to yes",
                "Reply hazy, try again", "Ask again later", "Better not tell you now", "Cannot predict now", "Concentrate and ask again",
                "Don't count on it", "My reply is no", "My sources say no", "Outlook not so good", "Very doubtful"};
    public static System.Random random = new System.Random();

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
    


using UnityEngine;

public class sword_script : MonoBehaviour
{
    public ParticleSystem Effect;
    private bool isSwitchedOn = false;

    private void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isSwitchedOn = !isSwitchedOn;
        }

        if (isSwitchedOn)
        {
            Effect.Play();
        }
        else
        {
           Effect.Stop();
        }
    }
}

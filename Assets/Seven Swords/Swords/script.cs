using UnityEngine;

public class ParticleSystemController : MonoBehaviour
{
    public ParticleSystem particleSystem;
    bool on_switch = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            on_switch = !on_switch;
        }

        if (on_switch)
        {
            particleSystem.Play();
        }
        else particleSystem.Stop();
    }
}

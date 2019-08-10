using UnityEngine;

public class EffectController : MonoBehaviour
{

    public ParticleSystem effect;
    public static ParticleSystem _effect;

    void Start()
    {
        _effect = effect;
    }

    public static void StartEmit()
    {
        _effect.Play();
    }
}

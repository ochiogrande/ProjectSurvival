using UnityEngine;

public class OlteanuPlayerViataControl : MonoBehaviour
{
    public static OlteanuPlayerViataControl instance;

    private void Awake()
    {
        instance = this;
    }
    public float viataCurrenta, viataMaxima;

    private void Start()
    {
        viataCurrenta = viataMaxima;
    }

    public void PrimesteDamage(float damagePrimit)
    {
        viataCurrenta -= damagePrimit;

        if(viataCurrenta <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}

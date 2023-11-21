using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Superpower[] superpowerList;
    [SerializeField] private float powerCooldown;

    // Start is called before the first frame update
    void Start()
    {
        superpowerList = GetComponents<Superpower>();

        StartCoroutine(ActivatePowers());
    }


    private IEnumerator ActivatePowers()
    {
        YieldInstruction wfs = new WaitForSeconds(powerCooldown);



        while (true)
        {
            Debug.Log("");

            foreach (Superpower superpower in superpowerList)
            {

                superpower.Activate();
            }

            yield return wfs;
        }
    }
}

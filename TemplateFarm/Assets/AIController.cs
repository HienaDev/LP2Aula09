using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{

    private List<AnimalsAI> animalsList;
    int turn;
    // Start is called before the first frame update
    void Start()
    {
        animalsList = new List<AnimalsAI>();

        animalsList.Add(new SheepAI());
        animalsList.Add(new WolvesAI());
        turn = 1;

        StartCoroutine(TakeTurns());
    }
    private IEnumerator TakeTurns ()
    {
        YieldInstruction wfs = new WaitForSeconds(2);

        

        while (true)
        {
            Debug.Log("");
            Debug.Log("Turn " + turn);
            Debug.Log("");

            foreach (AnimalsAI animal in animalsList)
            {
                
                animal.TakeTurn();
            }
            turn++;
            yield return wfs;
        }
    }
}

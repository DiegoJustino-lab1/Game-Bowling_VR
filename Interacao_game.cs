using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] bolos;

    private int pontos = 0;

    void Start()
    {
        bolos = GameObject.FindGameObjectsWithTag("bolo");
    }

    void Update()
    {

    }

    public void CalcularPuntos()
    {
        StartCoroutine(WaitForPuntos());
    }

    IEnumerator WaitForPuntos()
    {
        yield return new WaitForSeconds(8f);

        foreach (GameObject bolo in bolos)
        {
            Debug.Log(bolo.name + " - " + bolo.transform.localRotation.eulerAngles);

            if (bolo.transform.localRotation.eulerAngles.x < 258f || bolo.transform.localRotation.eulerAngles.x > 282f)
            {
                pontos++;
            }
        }

        if (puntos == 0)
            Debug.Log("Você é muito ruim!!!");
        else if (pontos != 10)
            Debug.Log("Sua pontuação é: " + pontos);
        else
            Debug.Log("STRIKE");

        yield return null;
    }
}
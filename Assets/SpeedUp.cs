/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    [SerializeField] float SpeedIncrease = 8f;
    [SerializeField] float SpeedIncreaseduration = 5f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            player p1 = collision.gameObject.GetComponent<player>();
            if (p1 != null)
            {

                StartCoroutine(PowerUp()){

                }
            }

        }
    }
    public IEnumerator PowerUp()
    {
        yield return new WaitForSeconds(SpeedIncreaseduration);
    }
}*/

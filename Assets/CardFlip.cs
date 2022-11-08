using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardFlip : MonoBehaviour
{
    public Animator anim;
    public bool turnedInCode;

    // Quand on clique
    private void OnMouseDown()
    {


        // On inverse la valeur de turned
        if(turnedInCode == true)
        {
            turnedInCode = false;
        }
        else //if (turnedInCode == false)
        {
            turnedInCode = true;
        }
        
        // On donne turned au bool de l'animator
        anim.SetBool("turned", turnedInCode);
        
        //Autre mani�re de l'�crire
        //turned = !turned;
        //anim.SetBool("turned", turned);
    }
}

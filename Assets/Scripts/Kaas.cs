using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kaas : InteractableItemBase
{
    private bool isPickedUp = false;
    public override void OnInteract()
    {
        InteractText = "Press F to";

        isPickedUp = !isPickedUp;

        InteractText += isPickedUp ? "to drop" : "to pickup";

        GetComponent<Animator>().SetBool("Pickedup", isPickedUp);
    }
}

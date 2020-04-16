using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableItemBase : MonoBehaviour
{
    // Start is called before the first frame update
    public string Name;

    public string InteractText = "Press F to pick up the item";

    public virtual void OnInteract()
    {

    }
}

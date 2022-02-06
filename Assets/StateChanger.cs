using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class StateChanger : MonoBehaviour
{
    public Trackable animalCell;
    public Trackable plantCell;
    public TextMesh prompt;
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {

        if (animalCell.isFound && plantCell.isFound)
        {
            prompt.text = "Found Both, Animal Cell and Plant Cell";
        }
        else if (animalCell.isFound)
        {
            prompt.text = "Found Animal Cell";
        }
        else if (plantCell.isFound)
        {
            prompt.text = "Found Plant cell";
        }
        else {
            prompt.text = "No Image Found";
        }
    }
}

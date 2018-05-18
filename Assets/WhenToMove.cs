using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class WhenToMove : MonoBehaviour
{
    [Header("The distance you need to be within...")]
    public float withinRange;
    [Header("...from this position...")]
    public Transform startPoint;
    [Header("...heading in this direction.")]
    public Transform endPoint;
    private MoveInstructions addPoints;


    // Update is called once per frame
    public void NextMove ()
    {
        addPoints = GameObject.Find("MoveBot").GetComponent<MoveInstructions>();
        addPoints.positions.Add(startPoint.position);
        addPoints.ranges.Add(withinRange);
        addPoints.directions.Add(endPoint.position - startPoint.position);
	}

    public void RemovePoint()
    {
            addPoints = GameObject.Find("MoveBot").GetComponent<MoveInstructions>();
            addPoints.positions.RemoveAt(addPoints.positions.Count - 1);
            addPoints.ranges.RemoveAt(addPoints.ranges.Count - 1);
            addPoints.directions.RemoveAt(addPoints.directions.Count - 1);
    }
}

using UnityEngine;

public class CourseSegment : MonoBehaviour
{
    public Transform[] checkPoints;

    public void PushCheckPoints(Transform[] mainCheckPointArray, ref int currentIndex)
    {
        for (int i = 0; i < checkPoints.Length; i++)
        {
            mainCheckPointArray[currentIndex] = checkPoints[i];
            currentIndex++;
        }
    }
}

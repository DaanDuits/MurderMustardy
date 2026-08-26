using UnityEngine;

public class CircleScript : MonoBehaviour
{
    private string suspectName;
    public void SetSuspectName(string name)
    {
        suspectName = name;
    }

    public bool CheckSuspectName(string name)
    {
        bool returnValue = false;

        if (name == suspectName) returnValue = true;

        return returnValue;
    }
}

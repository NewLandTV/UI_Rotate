using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private float rotateSpeed;

    [SerializeField]
    private RectTransform rotateGroup;

    private void LateUpdate()
    {
        rotateGroup.eulerAngles += Vector3.forward * rotateSpeed * Time.deltaTime;
    }

    // Button click events
    public void OnRotateRandomButtonClick()
    {
        rotateGroup.rotation = Quaternion.Euler(0f, 0f, Random.Range(0f, 360f));
    }
}

using UnityEngine;
using UnityEngine.UI;

public class TapText : MonoBehaviour
{
    public float SpawnTime = 0.5f;
    public Text Text;

    private float _spawnTime;

    private void OnEnable ()
    {
        _spawnTime = SpawnTime;
    }

    private void Update ()
    {
        _spawnTime -= Time.unscaledDeltaTime;
        if (_spawnTime <= 0f)
        {
            gameObject.SetActive (false);
        }
        else
        {
            Text.CrossFadeAlpha (0f, 0.5f, false);
            if (Text.color.a == 0f)
            {
                gameObject.SetActive (false);
            }
        }
    }
}

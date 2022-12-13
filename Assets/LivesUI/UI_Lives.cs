using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Lives : MonoBehaviour
{
    public Sprite[] _liveSprites;
    public Image _LivesImage;

    public void updateLives(int lives)
    {
        _LivesImage.sprite = _liveSprites[lives];
    }
    
}

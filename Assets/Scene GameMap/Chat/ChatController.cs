using UnityEngine;
using System.Collections;

public class ChatController : MonoBehaviour {

    private string _text;
    private GameObject _option1;
    private GameObject _option2;
    public int _charPerLine = 55;
    private bool _initTimer = false;
    private float _timerCount;
    private int _indx;

	void Start () {
        _text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce in diam consectetur, dictum sapien quis, placerat nunc. "+
            "Nullam mattis ligula sed sem ullamcorper, at tristique diam pellentesque. In cursus a elit dapibus faucibus. Mauris ultrices imperdiet nisi, "+
            "non fringilla nunc vulputate quis. Nulla eget blandit metus. Morbi placerat nisl ipsum, nec malesuada lacus dapibus sed. "+
            "Pellentesque malesuada lobortis felis, a ultricies nisi. Etiam dignissim enim et orci euismod, vitae dignissim nulla pretium. "+
            "Vivamus libero nunc, placerat gravida elit vitae, facilisis dapibus ipsum.";

        _text = SplitLines(_text);

        this.guiText.text = "";
        _indx = 0;
        _timerCount = 0;
        _initTimer = true;

	}
    public string SplitLines(string value)
    {
        string[] partial = value.Split(' ');
        int total = 0;
        string formatted = "";
        for (int i = 0; i < partial.Length; i++)
        {
            total += (partial[i].Length + 1);
            //Debug.Log(total);
            if (total > 55)
            {
                total = partial[i].Length + 1;
                formatted += "\n";
            }
            formatted += (partial[i] + " ");
        }
        return formatted;
    }
	
	
	void Update () {
        if (_initTimer)
        {
            _timerCount += Time.deltaTime;
            if (_timerCount > 0.02f)
            {
                _timerCount = 0;
                this.guiText.text += _text[_indx];
                _indx++;
                if (_indx >= _text.Length)
                {
                    _initTimer = false;
                }
            }
        }
	}

    public void ShowText()
    {
        
    }
    public void NextText()
    {

    }
}

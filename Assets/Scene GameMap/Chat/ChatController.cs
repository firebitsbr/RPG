using UnityEngine;
using System.Collections;

public class ChatController : MonoBehaviour {

    // input text
    private string _text;

    // button option 1
    public GameObject _option1;
    // button option 2
    public GameObject _option2;

    // number of letters per line
    public int _charPerLine = 55;

    // if is showing the letters or not
    private bool _initTimer = false;

    // timer to show the letters
    private float _timerCount;

    // number of letters in the line
    private int _indx;

    // number of the block of the thext
    private int _currentText;

    // array with the text formatted in blocks of 4 lines
    private ArrayList _textFormatted;

    // action to execute when finish the text
    private ActionTextType _actionFinish;

	void Start () {
        _text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce in diam consectetur, dictum sapien quis, placerat nunc. "+
            "Nullam mattis ligula sed sem ullamcorper, at tristique diam pellentesque. In cursus a elit dapibus faucibus. Mauris ultrices imperdiet nisi, "+
            "non fringilla nunc vulputate quis. Nulla eget blandit metus. Morbi placerat nisl ipsum, nec malesuada lacus dapibus sed. "+
            "Pellentesque malesuada lobortis felis, a ultricies nisi. Etiam dignissim enim et orci euismod, vitae dignissim nulla pretium. "+
            "Vivamus libero nunc, placerat gravida elit vitae, facilisis dapibus ipsum.";

        _textFormatted = SplitLines(_text);
        _currentText = 0;

        this.guiText.text = "";
        _indx = 0;
        _timerCount = 0;
        //_initTimer = true;
        this.gameObject.SetActive(false);


        _option1.SetActive(false);
        _option2.SetActive(false);
	}

    public ArrayList SplitLines(string value)
    {
        ArrayList retorno = new ArrayList();
        string[] partial = value.Split(' ');
        int total = 0;
        int lines = 0;
        string formatted = "";

        for (int i = 0; i < partial.Length; i++)
        {
            total += (partial[i].Length + 1);

            if (total > 55)
            {
                total = partial[i].Length + 1;
                lines++;
                if (lines == 4)
                {
                    lines = 0;
                    retorno.Add(formatted);
                    formatted = "";
                }
                else
                {
                    formatted += "\n";
                }
            }
            formatted += (partial[i] + " ");
        }
        retorno.Add(formatted);
        return retorno;
    }
    public void OnMouseDown()
    {
        if (_initTimer)
        {
            _initTimer = false;
            this.guiText.text = _textFormatted[_currentText].ToString();
        }
        else
        {
            _timerCount = 0;
            _indx = 0;
            _currentText++;
            this.guiText.text = "";
            if (_currentText >= _textFormatted.Count)
            {
                this.gameObject.SetActive(false);
            }
            else
            {
                _initTimer = true;
            }
        }
    }
	
	void Update () {
        if (_initTimer)
        {
            _timerCount += Time.deltaTime;
            if (_timerCount > 0.02f)
            {
                _timerCount = 0;
                this.guiText.text += _textFormatted[_currentText].ToString()[_indx];
                _indx++;
                if (_indx >= _textFormatted[_currentText].ToString().Length)
                {
                    _initTimer = false;
                }
            }
        }
	}
}
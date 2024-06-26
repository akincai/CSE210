public class Scripture
{

    private List<Word> _words = new List<Word>();
    private Reference _reference;
    // used to track indexes of words that have not been hidden yet
    private List<int> _shownIndexes = new List<int>();

    public Scripture(Reference reference, string text)
    {
        string[] parsedText = text.Split(" ");

        foreach (string word in parsedText)
            _words.Add(new Word(word));
        
        _reference = reference;

        for (int i = 0; i < _words.Count; i++)
            _shownIndexes.Add(i);
    }


    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            int selectedInd = new Random().Next(_shownIndexes.Count);
            /* I could just use selectedInd since it has the same index as its value, 
            but this represents accessing the value that I stored earlier 
            and would be used like this in other implementations*/
            _words[_shownIndexes[selectedInd]].Hide();
            // remove index from list of shown word indexes
            _shownIndexes.RemoveAt(selectedInd);
        }
    }

    public string GetDisplayText()
    {
        string concat = $"{_reference.GetDisplayText()}\n";
        for (int i = 0; i < _words.Count; i++)
        {
            if (i == 0)
                concat += _words[i].GetDisplayText();
            else
                concat += " "+_words[i].GetDisplayText();
        }
        return concat;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
                return false;
        }
        return true;
    }
}
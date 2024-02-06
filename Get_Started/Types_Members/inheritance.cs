// multiple inheritance

interface IControl
{
    void Paint();
}

interface ITextBox : IControl
{
    void SetText(string text);
}

interface IListBox: IControl
{
    void setItems(string[] items);
}

interface IComboBox : ITextBox, IListBox { }
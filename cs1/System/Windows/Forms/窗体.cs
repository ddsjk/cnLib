public class 窗体 : Form
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("WinForms Security", "WFO1000:缺少属性内容的代码序列化配置", Justification = "<挂起>")]
    public string 标题
    {
        get { return Text; }
        set { Text = value; }
    }
    public 窗体()
    { }
}

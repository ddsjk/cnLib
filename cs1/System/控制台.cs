public static class 控制台
{
    public static int 窗口高度
    {
        get { return Console.WindowHeight; }
        set { Console.WindowHeight = value; }
    }
    public static void 输出整行()
    {
        Console.WriteLine();
    }
    public static event ConsoleCancelEventHandler? 取消键按下
    {
        add { Console.CancelKeyPress += value; }
        remove { Console.CancelKeyPress -= value; }
    }
}
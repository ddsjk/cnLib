public sealed class 应用程序
{
    public static void 退出()
    {
        Application.Exit();
    }
    public static void 运行()
    {
        Application.Run();
    }

    public static void 运行(Form 主窗口)
    {
        Application.Run(主窗口);
    }
}
public class 随机
{
    Random 生成器;
    public 随机()
    {
        生成器 = new Random();
    }
    public 随机(int 种子)
    {
        生成器 = new Random(种子);
    }

    public int 下一个(int 最小值, int 最大值)
    {
        return 生成器.Next(最小值, 最大值);
    }


    public double 下一个双精度()
    {
        return 生成器.NextDouble();
    }
}

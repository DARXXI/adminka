using AdminPanel.Repository;
using AdminPanel.Domain.Entities;
using System.Numerics;
using System.Data;

class Program
{
    static int Main(string[] args)
    {
        int a = 5;

        switch (a)
        {
            case 5: a++;
                return a;

            default: a--;
                return a;

        }
    }
}

class MineException1 : Exception
{
    public int Code { get; set; }

    public MineException1 (int code)
    {
        Code = code;
    }
}
class MineException2 : Exception
{

}
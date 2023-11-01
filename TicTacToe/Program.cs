using TicTacToe;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        using (var g = new TicTacToeGame())
        {
            g.Run();
        }
    }
}
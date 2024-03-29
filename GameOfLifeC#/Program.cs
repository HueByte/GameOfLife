﻿using System.Diagnostics;
using System.Text;

bool performanceMode = false;
int delay = 50;
bool[][] mainGeneration = LoadInput();
int boundRow = mainGeneration.Length;
int boundCol = mainGeneration[0].Length;
object locker = new();
ulong gen = 0;

ParallelOptions options = new()
{
    MaxDegreeOfParallelism = Environment.ProcessorCount
};

Console.Clear();
(var left, var top) = Console.GetCursorPosition();

while (true)
{
    RenderGeneration();
    CalculateState();

    // delay between generations
    Thread.Sleep(delay);

    // no console clear to make the movement smoother
    Console.SetCursorPosition(left, top);
    gen++;
}

bool[][] RandomSeed()
{
    int boardSizeHeight = 128;
    int boardSizeWidth = 256;
    Random rnd = new();

    bool[][] board = new bool[boardSizeHeight][];

    for (int r = 0; r < board.Length; r++)
    {
        var col = new bool[boardSizeWidth];
        for (int c = 0; c < col.Length; c++)
        {
            // 70% for alive cell
            col[c] = rnd.Next(0, 100) <= 70;
        }

        board[r] = col;
    }

    return board;
}

bool[][] LoadInput()
{
    var PATH = AppContext.BaseDirectory + "Inputs";

    // Get txt files
    var files = Directory.GetFiles(Path.Join(PATH), "*.txt");

    Console.WriteLine("Should use performance mode? (1 - yes, Other input - no)");
    if (Console.ReadLine() == "1")
    {
        performanceMode = true;
        delay = 10;
        Console.WriteLine($"Performance mode {performanceMode}");
    }

    // Display input files to user
    Console.WriteLine("Select your input file from /Inputs folder: ");
    for (int i = 0; i < files.Length; i++)
        Console.WriteLine($"{i} - {files[i]}");

    Console.WriteLine($"{files.Length} - Random 128x256 (Console zoomout recommended)");

    // Get user input
    int result = -1;
    while (true)
    {
        Console.Write("Your choice: ");

        var userInput = int.TryParse(Console.ReadLine(), out result);
        if (userInput && !(result > files.Length) && !(result < 0) || result == files.Length) break;
    }

    if (result == files.Length) return RandomSeed();
    return ParseInput(File.ReadAllText(files[result]));
}

bool[][] ParseInput(string input)
{
    // remove empty chars at beggining and the end, then remove whitespaces
    input = input.Trim().Replace(" ", "");

    // create lines array
    var linesArr = input.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

    bool[][] output = new bool[linesArr.Length][];

    // parse string input
    for (int i = 0; i < output.Length; i++)
    {
        var temp = linesArr[i].ToCharArray();
        output[i] = new bool[temp.Length];

        for (int q = 0; q < output[i].Length; q++)
        {
            output[i][q] = temp[q] == 'x';
        }
    }

    return output;
}

void RenderGeneration()
{
    StringBuilder sb = new();

    for (int i = 0; i < mainGeneration.Length; i++)
    {
        for (int z = 0; z < mainGeneration[i].Length; z++)
        {
            if (performanceMode) sb.Append(mainGeneration[i][z] ? "x" : "·");
            else sb.Append(mainGeneration[i][z] ? $"\u001b[38;2;{50};{255};{16}m█" : $"\u001b[38;2;{00};{00};{00}m█");
        }

        sb.AppendLine();
    }

    Console.Write(sb.ToString());
    Console.WriteLine($"Generation: {gen}");
}

bool[][] CopyGrid(bool[][] source)
{
    var len = source.Length;
    var dest = new bool[len][];

    for (var x = 0; x < len; x++)
    {
        var inner = source[x];
        var ilen = inner.Length;
        var newer = new bool[ilen];
        Array.Copy(inner, newer, ilen);
        dest[x] = newer;
    }

    return dest;
}

void CalculateState()
{
    Stopwatch watch = new();
    watch.Start();
    bool[][] tempStateGrid = CopyGrid(mainGeneration);

    Parallel.For(0, tempStateGrid.Length, options, (row) =>
    {
        for (int col = 0; col < tempStateGrid[row].Length; col++)
        {
            int aliveNeighbors = CountNeighbors(row, col, tempStateGrid);

            mainGeneration[row][col] = DetermineState(aliveNeighbors, mainGeneration[row][col]);
        }
    });

    watch.Stop();
    Console.WriteLine($"{watch.ElapsedMilliseconds} ms");
}

int CountNeighbors(int row, int col, bool[][] tempStateGrid)
{
    int alive = 0;
    for (int r = -1; r <= 1; r++)
    {
        for (int c = -1; c <= 1; c++)
        {
            // check bounds
            if (row + r < 0 || row + r >= boundRow) continue;
            if (col + c < 0 || col + c >= boundCol) continue;

            // check if the same element
            if (c == 0 && r == 0) continue;

            // check the value
            if (tempStateGrid[row + r][col + c]) alive++;
        }
    }

    return alive;
}

bool DetermineState(int aliveNeightbors, bool orginal)
{
    if (aliveNeightbors < 2)
    {
        return false;
    }
    else if (aliveNeightbors == 3)
    {
        return true;
    }
    else if (aliveNeightbors > 3)
    {
        return false;
    }
    else return orginal;
}
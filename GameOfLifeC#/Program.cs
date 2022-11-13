// string input =
// @"
//     x x - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - -
//     x x - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - -
//     - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - -
//     - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - -
//     - - - - - - - - - - - - x - - - - - x x - - - - - - - - - - - - - - - -
//     - - - - - - - - - - x x - x x - - - x x - - - - - - - - - - - - - - - -
//     - - - - - - - - - - - x - x - - - - x x - - - - - - - - - - - - - - - -
//     - - - - - - - - - - - - x - - - - - x x - - - - - - - - - - - - - - - -
//     - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - -
//     - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - -
//     - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - -
// ";

string input =
@"
    x x - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - -
    x x - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - -
    - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - -
    - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - -
    - - - - - - - - - - - - x - - - - - x x - - - - - - - - - - - - - - - - - - - - - - - - - - - - x - - - - - x x - - - - - - - - - - - - - - - -
    - - - - - - - - - - x x - x x - - - x x - - - - - - - - - - - - - - - - - - - - - - - - - - x x - x x - - - x x - - - - - - - - - - - - - - - -
    - - - - - - - - - - - x - x - - - - x x - - - - - - - - - - - - - - - - - - - - - - - - - - - x - x - - - - x x - - - - - - - - - - - - - - - -
    - - - - - - - - - - - - x - - - - - x x - - - - - - - - - - - - - - - - - - - - - - - - - - - - x - - - - - x x - - - - - - - - - - - - - - - -
    - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - -
    - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - -
    - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - -
    x x - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - -
    x x - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - -
    - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - -
    - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - -
    - - - - - - - - - - - - x - - - - - x x - - - - - - - - - - - - - - - - - - - - - - - - - - - - x - - - - - x x - - - - - - - - - - - - - - - -
    - - - - - - - - - - x x - x x - - - x x - - - - - - - - - - - - - - - - - - - - - - - - - - x x - x x - - - x x - - - - - - - - - - - - - - - -
    - - - - - - - - - - - x - x - - - - x x - - - - - - - - - - - - - - - - - - - - - - - - - - - x - x - - - - x x - - - - - - - - - - - - - - - -
    - - - - - - - - - - - - x - - - - - x x - - - - - - - - - - - - - - - - - - - - - - - - - - - - x - - - - - x x - - - - - - - - - - - - - - - -
    - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - -
    - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - -
    - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - -
    x x - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - -
    x x - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - -
    - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - -
    - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - -
    - - - - - - - - - - - - x - - - - - x x - - - - - - - - - - - - - - - - - - - - - - - - - - - - x - - - - - x x - - - - - - - - - - - - - - - -
    - - - - - - - - - - x x - x x - - - x x - - - - - - - - - - - - - - - - - - - - - - - - - - x x - x x - - - x x - - - - - - - - - - - - - - - -
    - - - - - - - - - - - x - x - - - - x x - - - - - - - - - - - - - - - - - - - - - - - - - - - x - x - - - - x x - - - - - - - - - - - - - - - -
    - - - - - - - - - - - - x - - - - - x x - - - - - - - - - - - - - - - - - - - - - - - - - - - - x - - - - - x x - - - - - - - - - - - - - - - -
    - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - -
    - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - -
    - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - x x - - - - - - - - - - - - - - - -
";

// string input =
// @"
// - x -
// - - x
// x x x
// - - -
// ";

bool[][] mainGeneration = ParseInput(input);
int boundRow = mainGeneration.Length;
int boundCol = mainGeneration[0].Length;

Console.Clear();
while (true)
{
    RenderGeneration();
    CalculateState();
    Thread.Sleep(300);

    Console.Clear();
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
    for (int i = 0; i < mainGeneration.Length; i++)
    {
        for (int z = 0; z < mainGeneration[i].Length; z++)
        {
            Console.Write(mainGeneration[i][z] ? $"\u001b[38;2;{50};{255};{16}m█" : $"\u001b[38;2;{00};{00};{00}m█");
        }

        Console.WriteLine();
    }
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
    bool[][] tempStateGrid = CopyGrid(mainGeneration);

    for (int row = 0; row < tempStateGrid.Length; row++)
    {
        for (int col = 0; col < tempStateGrid[row].Length; col++)
        {
            int aliveNeighbors = CountNeighbors(row, col, tempStateGrid);

            // Console.WriteLine($"State [{row}] [{col}] -> {aliveNeighbors} {(aliveNeighbors == 3 ? "✅" : "")}");

            mainGeneration[row][col] = DetermineState(aliveNeighbors, mainGeneration[row][col]);
        }
    }
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
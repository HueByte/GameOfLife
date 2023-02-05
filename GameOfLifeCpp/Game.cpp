#include <iostream>
#include <vector>
#include <chrono>
#include <string>
#include <thread>

const int HEIGHT = 200;
const int WIDTH = 400;

int countAliveNeighbors(const std::vector<std::vector<bool>> &board, int row, int col)
{
    int count = 0;
    for (int i = -1; i <= 1; i++)
    {
        for (int j = -1; j <= 1; j++)
        {
            if (i == 0 && j == 0)
            {
                continue;
            }

            int r = row + i;
            int c = col + j;
            if (r >= 0 && r < HEIGHT && c >= 0 && c < WIDTH && board[r][c])
            {
                count++;
            }
        }
    }

    return count;
}

void updateBoard(std::vector<std::vector<bool>> &board)
{
    std::vector<std::vector<bool>> newBoard(HEIGHT, std::vector<bool>(WIDTH, false));
    for (int i = 0; i < HEIGHT; i++)
    {
        for (int j = 0; j < WIDTH; j++)
        {
            int count = countAliveNeighbors(board, i, j);
            if (board[i][j])
            {
                if (count == 2 || count == 3)
                {
                    newBoard[i][j] = true;
                }
            }
            else
            {
                if (count == 3)
                {
                    newBoard[i][j] = true;
                }
            }
        }
    }
    board = newBoard;
}

void printBoard(const std::vector<std::vector<bool>> &board)
{
    std::string output("");

    std::cout << "\033[2J\033[1;1H"; // clear the terminal
    for (int i = 0; i < HEIGHT; i++)
    {
        for (int j = 0; j < WIDTH; j++)
        {
            if (board[i][j])
            {
                output.append("x");
            }
            else
            {
                output.append("·");
            }
        }

        output.append("\n");
    }

    std::cout << output;
}

int main()
{
    std::vector<std::vector<bool>> board(HEIGHT, std::vector<bool>(WIDTH, false));
    // seed the board with alive cells
    board[10][20] = true;
    board[11][19] = true;
    board[11][20] = true;
    board[11][21] = true;
    board[12][20] = true;

    while (true)
    {
        printBoard(board);
        updateBoard(board);
        std::this_thread::sleep_for(std::chrono::milliseconds(50));
    }

    return 0;
}

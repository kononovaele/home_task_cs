//
// Напишите задачу, которая принимает на вход число N
//

Console.WriteLine("--- Task_8 ---");

int N = 11;
int count = 1;

while( count <= N ) {
    if(count % 2 == 0) {
        Console.WriteLine(count);
    }
    count = count + 1;
}

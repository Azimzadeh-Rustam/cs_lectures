// Найти самый первый индекс элемента в массиве со значением из переменной find

void FillArray(int[] collection){
    int length = collection.Length;
    int index = 0;
    while(index < length){
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col){
    int count = col.Length;
    int position = 0;
    Console.Write("numbers = {");
    while(position < count){
        Console.Write($"{col[position]},");
        position++;
    }
    Console.Write("}");
}

int IndexOf(int[] collection, int find){
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index < count){
        if(collection[index] == find){
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] numbers = new int[10];
int find = 4;

FillArray(numbers);
PrintArray(numbers);
Console.WriteLine();

int pos = IndexOf(numbers, find);
Console.WriteLine(pos);
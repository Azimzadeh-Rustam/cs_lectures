// Найти максимальное число

int FindMax(int[] collection) {
    int max = collection[0];
    int length = collection.Length;
    int index = 0;
    while(index < length){
        if(collection[index] > max){
            max = collection[index];
        }
        index++;
    }
    return max;
}

int[] numbers = {5,45,6,75,7,94,1,13,64};

int max = FindMax(numbers);

Console.WriteLine(max);